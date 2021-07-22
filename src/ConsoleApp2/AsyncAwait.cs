using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    public class AsyncAwait
    {

        public static void CallMe() {

            Console.WriteLine($"Main Method: Before calling AsyncMethod {Thread.CurrentThread.ManagedThreadId}");
            AsyncMethod();
            Console.WriteLine($"Main Method: After calling AsyncMethod {Thread.CurrentThread.ManagedThreadId}");
        }


        public static async void AsyncMethod() {

            Console.WriteLine($"AsyncMethod: Before Wait {Thread.CurrentThread.ManagedThreadId}");
            await Task.Run(new Action(Method2));
            await Task.Delay(5000);
            Console.WriteLine($"AsyncMethod: After Wait {Thread.CurrentThread.ManagedThreadId}");
        }

        private static void Method2() {

            Console.WriteLine($"Method2: Before Wait {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(4000);
            Console.WriteLine($"Method2: After Wait {Thread.CurrentThread.ManagedThreadId}");
        }

    }
}
