using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class VarRefIn
    {

        public static void FnRef(ref string x) {
            
            x = "modified";
            Console.WriteLine(x);
        }

        public static void FnOut(out string x)
        {
            x = "modified";
            Console.WriteLine(x);
        }

        public static void FnIn(in string x)
        {
            Console.WriteLine(x);
        }

        internal class Test {
           internal int x = 1;
            internal Test(int input) { x = input; }
        }

        internal static void FnClassType(Test tst)
        {
            tst.x = 2;
        }


        public static void CallMe() {

            var x = "initial";
            FnRef(ref x);
            Console.WriteLine(x);

            var y = "initial";

            FnOut(out y);
            Console.WriteLine(y);

            var z = "initial";

            FnIn(z);
            Console.WriteLine(z);

            Test obj = new Test(1);
            Console.WriteLine($"Before: {obj.x}");
            FnClassType(obj);
            Console.WriteLine($"After: {obj.x}");

        }

    }
}
