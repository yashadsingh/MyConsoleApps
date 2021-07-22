using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Singletontt
    {
        public int x = 88;
        public static Singletontt _singlObj;

        private Singletontt()
        {

        }

        public static Singletontt CreateObject()
        {

            if (_singlObj == null)
                return new Singletontt();
            else
                return _singlObj;
        }

    }


    public static class StaticClass
    {
        static int i = 0;

    }

    public class Test1
    {

        public static void Call() {

            var dd = Singletontt.CreateObject();

            dd.x = 99;
        }
    }
}
