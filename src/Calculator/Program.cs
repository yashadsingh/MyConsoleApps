using Microsoft.Extensions.DependencyInjection;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator obj = new Calculator();
            Console.WriteLine("Enter a command");
            while (true)
            {
                obj.CallMe(Console.ReadLine().Split(" "));
            }
            //obj.CallMe(new string[] { "count", "sum" });
            //obj.CallMe(new string[] { "add", "2,2,2" });
            //obj.CallMe(new string[] { "count", "sum" });
            //obj.CallMe(new string[] { "Mult", "9,2,1" });
            //obj.CallMe(new string[] { "MultiplicatioN", "3,2,1" });
            Console.Read();
        }
    }
}
