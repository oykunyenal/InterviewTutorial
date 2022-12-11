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
    public abstract class BaseRequestCreator
    {
        public BaseRequestCreator()
        {

        }

        protected delegate string GetBaseAddressDelegate();
        GetBaseAddressDelegate getBaseAddressDelegateMethod;

        private delegate string MakeRequestDelagate();
        MakeRequestDelagate makeRequestDelagateMethod;

        public delegate void RequestStartedDelegate();
        RequestStartedDelegate requestStartedDelegateMethod;

        Func<int> requestCountFunc;

        private HttpMethod httpMethod;

        protected void SetRequestCount(int count)
        {
            requestCountFunc = () => count;
        }

 
        protected void SetBaseAddressMethod(GetBaseAddressDelegate paramDelegateMethod)
        {
            getBaseAddressDelegateMethod = paramDelegateMethod;
        }

        public void SetRequestStartedMethod(RequestStartedDelegate paramRequestStartedMethod)
        {
            this.requestStartedDelegateMethod = paramRequestStartedMethod;
        }

        private string MakeGETRequest()
        {
            HttpClient httpClient = new HttpClient();

            var baseAddress = getBaseAddressDelegateMethod.Invoke();

            var msg = new HttpRequestMessage
            {
                Method = httpMethod,
                RequestUri = new Uri(baseAddress + GetUrlPath())
            };
        }




        protected string MakeRequest()
        {

            HttpClient httpClient = new HttpClient();

            httpClient.BaseAddress = new Uri(GetBaseAddress());
            var httpResponse = httpClient.GetAsync("posts").GetAwaiter().GetResult();

            httpResponse.EnsureSuccessStatusCode();

            var contentResult = httpResponse.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            return contentResult;
        }

        protected virtual string GetBaseAddress()
        {
            return "";
        }

        protected virtual string GetUrlPath()
        {
            return "";
        }
    }
}
