using InverviewTutorial.FuncActionEventDelegate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InverviewTutorial.FuncActionEventDelegate.RequestCreaters
{
    public class CreatePostRequestCreator : BaseRequestCreator
    {
        public PostModel CreatePost()
        {
            var responseContent = base.MakeRequest();
            return JsonSerializer.Deserialize<PostModel>(responseContent);
        }
    }
}
