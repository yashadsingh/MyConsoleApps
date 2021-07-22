using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ConsoleApp1ClassLibrary2Class1
    {
        public int publicInt = 1;
        private int privateInt = 2;
        protected int protectedInt = 3;
        private protected int privateProtectedInt = 4;
        internal int internalInt = 5;
        protected internal int protectedInternalInt = 6;

        private protected int private_protected()
        {
            return 1;
        }
        protected internal int protected_internal()
        {
            return 1;
        }

    }

    public class ConsoleApp1ClassLibrary2Class2 : ConsoleApp1ClassLibrary2Class1
    {

        public void foo()
        {
            private_protected();
            protected_internal();

            ConsoleApp1ClassLibrary2Class1 obj = new ConsoleApp1ClassLibrary2Class1();
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

    public class ConsoleApp1AccessModifiers
    {

        public static void CallMe()
        {
            ConsoleApp1ClassLibrary2Class1 obj = new ConsoleApp1ClassLibrary2Class1();
            Console.WriteLine(obj.protected_internal());
        }

    }
}
