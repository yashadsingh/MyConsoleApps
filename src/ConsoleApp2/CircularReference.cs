using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CircularReference
    {
        class A
        {
            public B objB = new B();
        }

        class B
        {
            public A objA = new A();

        }
        
    }
}
