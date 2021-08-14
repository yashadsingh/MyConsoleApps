using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace ConsoleApp2
{

    public class AsyncAwait
    {

        public static async void CallMe()
        {

            List<int> dd = new List<int>();
            int[,] hh = new int[3, 3] { { 1, 2, 1 }, { 1, 2, 1 }, { 1, 2, 1 } };

            Console.WriteLine($"Before Run Thread = {Thread.CurrentThread.ManagedThreadId}");
            await Task.Run(() =>
             {
                 try
                 {
                     throw new Exception($"errrrrr Thread = {Thread.CurrentThread.ManagedThreadId}");

                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine(ex.Message);
                 }
                 Task.Delay(10000); });//.ConfigureAwait(false);
            //var yy = tt.ConfigureAwait(false);

            //Console.WriteLine(tt);
            Console.WriteLine($"After Run Thread = {Thread.CurrentThread.ManagedThreadId}");

        }

        public static async void CallMe3()
        {

            Console.WriteLine($"Before Async/Await call Thread = {Thread.CurrentThread.ManagedThreadId}");
            await DelayTask();
            Console.WriteLine($"After Async/Await call Thread = {Thread.CurrentThread.ManagedThreadId}");

        }

        public static Task DelayTask()
        {
            Thread.Sleep(5000);
            Console.WriteLine($"Task Completed Thread = {Thread.CurrentThread.ManagedThreadId}");
            return Task.CompletedTask;
        }

        public static void CallMe2()
        {

            Console.WriteLine($"Main Method: Before calling AsyncMethod {Thread.CurrentThread.ManagedThreadId}");
            AsyncMethod();
            Console.WriteLine($"Main Method: After calling AsyncMethod {Thread.CurrentThread.ManagedThreadId}");
        }


        public static async void AsyncMethod()
        {

            Console.WriteLine($"AsyncMethod: Before Wait {Thread.CurrentThread.ManagedThreadId}");
            await Task.Run(new Action(Method2));
            await Task.Delay(5000);
            Console.WriteLine($"AsyncMethod: After Wait {Thread.CurrentThread.ManagedThreadId}");
        }

        private static void Method2()
        {

            Console.WriteLine($"Method2: Before Wait {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(4000);
            Console.WriteLine($"Method2: After Wait {Thread.CurrentThread.ManagedThreadId}");
        }

    }
}
