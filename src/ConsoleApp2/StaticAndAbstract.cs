using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class StaticAndAbstract
    {

        static class A
        {
            public static int MyProperty = 2;
            static A()
            {
                MyProperty = 99;
            }

            static void foo()
            {
                int sss;

            }

        }

        public static void CallMe()
        {
            Console.WriteLine(A.MyProperty);
        }

        class B
        {
            static int x = 9;
            public int MyProperty { get; set; }
            static void foo()
            {
                Console.WriteLine(x);
            }
        }

        internal abstract class C
        {
            internal C()
            {
                Console.WriteLine("C");
            }

        }

        internal class D: C
        {
            D()
            {
                Console.WriteLine("D");
            }

            internal static void CallMe()
            {
                C obj = new D();
            }

        }


    }
}
