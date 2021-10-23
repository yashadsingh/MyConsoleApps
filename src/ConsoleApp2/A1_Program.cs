using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
//using System.Web.Helpers;
using System.Linq;
using System.Threading;

namespace ConsoleApp2
{
    // Contravariant interface.
    interface IContravariant<in A> { }

    // Extending contravariant interface.
    //interface IExtContravariant<in A> : IContravariant<A> { }

    class Sample<A> : IContravariant<A> { }


    class A1_Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"***** START ****** Thread = {Thread.CurrentThread.ManagedThreadId}");
            StaticAndAbstract.D.CallMe();
            Console.WriteLine($"***** END ****** Thread = {Thread.CurrentThread.ManagedThreadId}");
            Console.Read();

        }

    }


}


