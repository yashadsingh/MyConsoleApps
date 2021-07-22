using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ObjectSlice
    {

        class A {

            public void foo() {

                Console.WriteLine("Class A >> Foo");
            }
        
        }

        class B: A
        {

            public void foo()
            {

                Console.WriteLine("Class B >> Foo");
            }

        }
        public static void CallMe() {

            A obj = new B();

            obj.foo();
        
        }


    }
}
