using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class HierarchyClasses
    {

        public abstract class Parent
        {

            public Parent(int x)
            {
                Console.WriteLine(x);
            }

            public int Foo(int a) { return 1; }

        }
        public class Child : Parent
        {

            public Child(int x): base(2)
            {
                Console.WriteLine(x);
            }
            public string Foo(int a) { return ""; }

        }

        public static void CallMe() {

            Parent obj = new Child(1);
        
        }

    }
}
