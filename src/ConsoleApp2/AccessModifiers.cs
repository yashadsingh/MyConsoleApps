using ConsoleApp1;
using ConsoleDiffenerebtNameSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDiffenerebtNameSpace
{
    class CheckInternal : ConsoleApp1ClassLibrary2Class1
    {

        public void foo() {
            protectedInternalInt = 0;
            //privateProtectedInt = 9;
            protectedInt = 0;

            //private_protected(); not accessible due to different assembly

            protected_internal();
        }

        private protected int Foo()
        {
            ConsoleApp1ClassLibrary2Class1 obj = new CheckInternal();
            //obj.protected_internal(); not accesible due to internal
            return 1;
        }

    }

}

namespace ConsoleApp2
{
    public class AccessModifiers
    {

        public class ClassLibrary2Class1
        {
            CheckInternal obj = new CheckInternal();

            public int publicInt = 1;
            private int privateInt = 2;
            protected int protectedInt = 3;
            private protected int privateProtectedInt = 4;
            internal int internalInt = 5;
            protected internal int protectedInternalInt = 6;

            int ProtectedMethod()
            {
                return 1;
            }

            private protected int private_protected() {
                return 1;
            }

        }


        public class ClassLibrary2Class2 : ClassLibrary2Class1
        {

            public int ProtectedMethod()
            {
                private_protected();
                return 2;
            }

            public void foo()
            {

                ClassLibrary2Class1 obj = new ClassLibrary2Class1();
                Console.WriteLine(obj.publicInt);
                // Console.WriteLine(obj.privateInt); Not Accessible
                // Console.WriteLine(obj.protectedInt); Not Accessible
                // Console.WriteLine(obj.privateProtectedInt); Not Accessible
                Console.WriteLine(obj.internalInt);
                Console.WriteLine(obj.protectedInternalInt);

                Console.WriteLine(publicInt);
                // Console.WriteLine(privateInt); Not Accessible
                Console.WriteLine(protectedInt);
                Console.WriteLine(privateProtectedInt);
                Console.WriteLine(internalInt);
                Console.WriteLine(protectedInternalInt);
            }

        }


        public class ClassLibrary2Class3 : ClassLibrary2Class2
        {

            public void foo()
            {

                ClassLibrary2Class1 obj = new ClassLibrary2Class1();
                Console.WriteLine(obj.publicInt);
                // Console.WriteLine(obj.privateInt); Not Accessible
                // Console.WriteLine(obj.protectedInt); Not Accessible
                // Console.WriteLine(obj.privateProtectedInt); Not Accessible
                Console.WriteLine(obj.internalInt);
                Console.WriteLine(obj.protectedInternalInt);

                Console.WriteLine(publicInt);
                // Console.WriteLine(privateInt); Not Accessible
                Console.WriteLine(protectedInt);
                Console.WriteLine(privateProtectedInt);
                Console.WriteLine(internalInt);
                Console.WriteLine(protectedInternalInt);
            }

        }

        public static void CallMe()
        {
            ClassLibrary2Class1 obj = new ClassLibrary2Class2();
            Console.WriteLine(obj.protectedInternalInt);
        }

    }
}
