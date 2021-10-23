using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Consumers
{
    public class WebAPI_1
    {
        private static readonly HttpClient _client = new HttpClient();

        public async Task TestTask()
        {
            int wait = 100;
            Console.WriteLine($"TestTask Waiting for {wait} millisec. : ThreadState - {Thread.CurrentThread.ThreadState}, ThreadID - {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(wait);

            Console.WriteLine($"TestTask called GetFromAPI(): ThreadState - {Thread.CurrentThread.ThreadState}, ThreadID - {Thread.CurrentThread.ManagedThreadId}");

            GetFromAPI();

            Console.WriteLine($"TestTask after calling GetFromAPI(): ThreadState - {Thread.CurrentThread.ThreadState}, ThreadID - {Thread.CurrentThread.ManagedThreadId}");

        }

        public async Task GetFromAPI()
        {
            int wait = 200;
            Console.WriteLine($"GetFromAPI Waiting for {wait} millisec. : ThreadState - {Thread.CurrentThread.ThreadState}, ThreadID - {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(wait);

            Console.WriteLine($"GetFromAPI after waiting for {wait} millisec. : ThreadState - {Thread.CurrentThread.ThreadState}, ThreadID - {Thread.CurrentThread.ManagedThreadId}");
        }


        public void TestTask_2()
        {
            int i = 100;
            while (i > 0)
            {
                Task.Run(() =>
                {
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} - {Thread.CurrentThread.ThreadState} - Task Run({i})");
                });
                i--;
            }

        }

        public async Task TestTask_3()
        {
            Stopwatch stopwatch = new Stopwatch();
            int i = 100;
            stopwatch.Start();
            while (i > 0)
            {
                LongRunning(i);
                i--;
            }
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
        }

        private async Task LongRunning(int i)
        {
            await Task.Delay(1);
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} - {Thread.CurrentThread.ThreadState} - LongRunning({i})");
        }


        public static void CallMe()
        {

            HttpResponseMessage response = _client.GetAsync(
                "https://localhost:44373/api/Cart").Result;

            var stringContent = new StringContent("");
            stringContent.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
            response = _client.PostAsync(
                "https://localhost:44373/api/Cart", stringContent).Result;

            response = _client.GetAsync(
                "https://localhost:44373/api/Cart").Result;

            response.EnsureSuccessStatusCode();

        }

    }
}
