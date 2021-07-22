using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //public class VirtualKeyword
    //{
        public class A
        {
            public A() {
                Console.WriteLine("Ctor A");
            }

            public void F() { Console.WriteLine("A.F"); }
        }
        class B : A
        {
            public B()
            {
                Console.WriteLine("Ctor B");
            }

            public  void F() { Console.WriteLine("B.F"); }
        }
        //class C : B
        //{
        //    public C()
        //    {
        //        Console.WriteLine("Ctor C");
        //    }
        //    new public virtual void F() { Console.WriteLine("C.F"); }
        //}
        //class D : C
        //{
        //    public override void F() { Console.WriteLine("D.F"); }
        //}

        class VirtualKeywordCall
        {
            public static void CallMe()
            {
                A d = new B();
                d.F();

            }
        }

    //}
}
