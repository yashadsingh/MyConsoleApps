using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Consumers
{
    public class WebAPI_1
    {
        private static readonly HttpClient _client = new HttpClient();

        public static void CallMe()
        {

            HttpResponseMessage response = _client.GetAsync(
                "https://localhost:8989/api/Cart").Result;

            var stringContent = new StringContent("");
            stringContent.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
            response = _client.PostAsync(
                "https://localhost:8989/api/Cart", stringContent).Result;

            response = _client.GetAsync(
                "https://localhost:8989/api/Cart").Result;

            response.EnsureSuccessStatusCode();

        }

    }
}
