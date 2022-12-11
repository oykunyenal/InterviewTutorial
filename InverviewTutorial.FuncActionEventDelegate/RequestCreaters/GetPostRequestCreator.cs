using InverviewTutorial.FuncActionEventDelegate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InverviewTutorial.FuncActionEventDelegate.RequestCreaters
{
    public class GetPostRequestCreator : BaseRequestCreator
    {
       public List<PostModel> GetPosts()
        {
            var responseContent = base.MakeRequest();
            return JsonSerializer.Deserialize<List<PostModel>>(responseContent);
        }
    }
}
