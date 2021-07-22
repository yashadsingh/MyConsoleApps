using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Delegates
    {
        public delegate void Add(int a, int b);
        public static void AddTwoIntegers(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void CallMe()
        {
            Add tmpAddTwo = new Add(AddTwoIntegers);
            tmpAddTwo(2, 1);
        }

    }
}
