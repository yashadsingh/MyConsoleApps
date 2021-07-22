using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CoAndContraVariance
    {

        public class Parent
        { }

        public class Child : Parent { }

        public static void CallMe()
        {

            var listParentObj = new List<Parent>() {
                new Parent(),
                new Parent()
            };

            var listChildObj = new List<Child>() {
                new Child(),
                new Child()
            };

           // IEnumerable<Child> obj1 = listParentObj;
           // IEnumerable<Parent> obj2 = listChildObj;



        }

    }
}
