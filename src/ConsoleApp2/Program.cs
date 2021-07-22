using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Web.Helpers;
using System.Linq;

namespace ConsoleApp2
{
    // Contravariant interface.
    interface IContravariant<in A> { }

    // Extending contravariant interface.
    //interface IExtContravariant<in A> : IContravariant<A> { }

    class Sample<A> : IContravariant<A> { }


    class Program
    {
        static void Main(string[] args)
        {

            AsyncAwait.CallMe();
            Console.Read();

        }

    }


}


