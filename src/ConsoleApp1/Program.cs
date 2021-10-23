using ConsoleApp1.Consumers;
using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The End. Type 'c' to run again.");
            while (Console.ReadLine().ToString().Equals("c"))
            {
                var caller = new WebAPI_1();
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} - {Thread.CurrentThread.ThreadState} - Main()");
                caller.TestTask();
                caller.TestTask_2();
                caller.TestTask_3();
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} - {Thread.CurrentThread.ThreadState} - Main()");
                Console.WriteLine("The End. Type 'c' to run again.");
            }

            Console.ReadLine();
        }
    }


    //namespace ParallelExample
    //{
    //    class Program
    //    {
    //        static void Main()
    //        {

    //            // 2 million
    //            var limit = 2_000_000;
    //            var numbers = Enumerable.Range(0, limit).ToList();

    //            var watch = Stopwatch.StartNew();
    //            var primeNumbersFromForeach = GetPrimeList(numbers);
    //            watch.Stop();

    //            var watchForParallel = Stopwatch.StartNew();
    //            var primeNumbersFromParallelForeach = GetPrimeListWithParallel(numbers);
    //            watchForParallel.Stop();

    //            Console.WriteLine($"Classical foreach loop | Total prime numbers : {primeNumbersFromForeach.Count} | Time Taken : {watch.ElapsedMilliseconds} ms.");
    //            Console.WriteLine($"Parallel.ForEach loop  | Total prime numbers : {primeNumbersFromParallelForeach.Count} | Time Taken : {watchForParallel.ElapsedMilliseconds} ms.");

    //            Console.WriteLine("Press any key to exit.");
    //            Console.ReadLine();
    //        }

    //        /// <summary>
    //        /// GetPrimeList returns Prime numbers by using sequential ForEach
    //        /// </summary>
    //        /// <param name="inputs"></param>
    //        /// <returns></returns>
    //        private static IList<int> GetPrimeList(IList<int> numbers) => numbers.Where(IsPrime).ToList();

    //        /// <summary>
    //        /// GetPrimeListWithParallel returns Prime numbers by using Parallel.ForEach
    //        /// </summary>
    //        /// <param name="numbers"></param>
    //        /// <returns></returns>
    //        private static IList<int> GetPrimeListWithParallel(IList<int> numbers)
    //        {
    //            var primeNumbers = new ConcurrentBag<int>();

    //            Parallel.ForEach(numbers, number =>
    //            {
    //                if (IsPrime(number))
    //                {
    //                    primeNumbers.Add(number);
    //                }
    //            });

    //            return primeNumbers.ToList();
    //        }

    //        /// <summary>
    //        /// IsPrime returns true if number is Prime, else false.(https://en.wikipedia.org/wiki/Prime_number)
    //        /// </summary>
    //        /// <param name="number"></param>
    //        /// <returns></returns>
    //        private static bool IsPrime(int number)
    //        {
    //            if (number < 2)
    //            {
    //                return false;
    //            }

    //            for (var divisor = 2; divisor <= Math.Sqrt(number); divisor++)
    //            {
    //                if (number % divisor == 0)
    //                {
    //                    return false;
    //                }
    //            }
    //            return true;
    //        }
    //    }
    //}

    //    public static void CallToChildThread()
    //    {
    //        try
    //        {
    //            Console.WriteLine("Child thread starts");
    //            DateTime dt = DateTime.Now;
    //            //Console.WriteLine("Child thread starts");

    //            // do some work, like counting to 10
    //            for (int counter = 0; counter <= 100; counter++)
    //            {
    //                //Thread.Sleep(500);
    //                //Int64 sum = 0;
    //                //Int64 N = 5;

    //                //Thread.VolatileWrite(ref sum, N / 5);
    //                //Thread.VolatileRead(ref sum);
    //                //Thread.SpinWait(1000000);

    //                Console.WriteLine(counter);
    //                Console.WriteLine("Yeild: " + Thread.Yield());
    //            }

    //            Console.WriteLine((DateTime.Now - dt).Milliseconds);
    //            Console.WriteLine("Child Thread Completed");
    //        }
    //        catch (ThreadAbortException e)
    //        {
    //            Console.WriteLine("Thread Abort Exception");
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Couldn't catch the Thread Exception");
    //        }
    //    }

    //    static void Main(string[] args)
    //    {

    //        //Parent obj = new Child();

    //        //obj.Foo1();


    //        //Child obj1 = new Child();

    //        //obj1.Foo1();

    //        Parent obj = new Child();

    //        obj.VFoo();

    //        Console.ReadLine();



    //    }

    //    public void foo()
    //    {

    //        Class1 obj = new Class1();

    //        Console.WriteLine("publicInt: " + publicInt);
    //        Console.WriteLine("protectedInt: " + protectedInt);
    //        Console.WriteLine("protectedInternalInt: " + protectedInternalInt);

    //    }

    //    static void Main2(string[] args)
    //    {
    //        //Console.WriteLine("Yeild: " + Thread.Yield());
    //        ThreadStart childref = new ThreadStart(CallToChildThread);
    //        Console.WriteLine("In Main: Creating the Child thread");

    //        Thread childThread = new Thread(childref);
    //        childThread.Start();

    //        //
    //        //Console.WriteLine("stop the main thread for some time");

    //        //now abort the child
    //        Console.WriteLine("In Main: Aborting the Child thread");

    //        Console.WriteLine("Yeild: " + Thread.Yield());
    //        //;
    //        //childThread.Abort();
    //        Console.ReadKey();
    //    }

    //    public static Int64 sum = 0;

    //    /// <summary>
    //    /// 
    //    /// </summary>
    //    /// <param name="args"></param>
    //    static void Main1(string[] args)
    //    {
    //        ////MyClass my = new MyClass();
    //        //List<MyClass> my1 = MyClass.singleObj;
    //        ////Console.WriteLine(MyClass.count);

    //        ////MyClass your = new MyClass();
    //        //List<MyClass> your1 = MyClass.singleObj;
    //        ////Console.WriteLine(MyClass.count);

    //        ////MyClass mine = new MyClass();
    //        //List<MyClass> mine1 = MyClass.singleObj;
    //        ////Console.WriteLine(MyClass.count);
    //        ///
    //        //Thread t = new Thread(() => WriteY(1));          // Kick off a new thread
    //        //t.Start();                               // running WriteY()

    //        //// Simultaneously, do something on the main thread.
    //        //for (int i = 0; i < 1000; i++) Console.Write("x");


    //        Test obj = new Test(Convert.ToInt64(Console.ReadLine()));
    //        obj.Sum();
    //        Console.ReadLine();
    //    }


    //    static void WriteY(Int64 N)
    //    {
    //        for (int i = 0; i < 1000; i++)
    //            sum += sum;
    //    }

    //}

    //public class Test123: Class1
    //{

    //    public void foooo() {

    //        Class1 obj = new Class1();
    //        Console.WriteLine(obj.publicInt);

    //        Console.WriteLine(publicInt);
    //        Console.WriteLine(protectedInt);
    //        Console.WriteLine(protectedInternalInt);

    //    }

    //}

    //public class Parent
    //{

    //    public void Foo1()
    //    {

    //        Console.WriteLine("Parent");
    //    }

    //    public virtual void VFoo()
    //    {

    //        Console.WriteLine("Vistrual Parent");
    //    }

    //}


    //public class Child : Parent
    //{

    //    public new void Foo1()
    //    {
    //        Console.WriteLine("Child");
    //    }

    //    public override void VFoo()
    //    {
    //        Console.WriteLine("Vistrual Child");
    //    }

    //}


    //public abstract class AbstractParent
    //{

    //    public abstract void fooo();

    //}

    //public class ChildForAbstract : AbstractParent
    //{

    //    public override void fooo()
    //    {

    //    }

    //}




    //public class Test
    //{

    //    public Int64 N;

    //    public Int64 N1;
    //    public Int64 N2;

    //    public Int64 result;

    //    public Test(Int64 Num)
    //    {
    //        N = Num;

    //        //if (N % 2 == 0)
    //        //{
    //        //    N1 = N / 2;
    //        //    N2 = N1;
    //        //}
    //        //else
    //        //{

    //        //    N1 = (N - 1) / 2;
    //        //    N2 = N1;
    //        //}

    //    }

    //    public void Sum()
    //    {
    //        DateTime dtStart = DateTime.Now;

    //        if (N % 2 == 0)
    //        {

    //            for (Int64 index = 1; index < N / 2; index++)
    //            {
    //                result += (N / index) + (N / (N - index));
    //            }

    //            result += 2 + 1;
    //        }
    //        else
    //        {

    //            for (Int64 index = 1; index <= N / 2; index++)
    //            {
    //                result += (N / index) + (N / (N - index));
    //            }

    //            result += 1;
    //        }

    //        Console.WriteLine(result);
    //        Console.WriteLine((DateTime.Now - dtStart).TotalMilliseconds);
    //        Console.WriteLine((DateTime.Now - dtStart).TotalSeconds);

    //    }

    //}

    ////public class MySecondClass : MyClass
    ////{

    ////    public void Main1()
    ////    {
    ////        Console.WriteLine("Hello!");
    ////    }

    ////}

    //public class MyClass
    //{
    //    private static List<MyClass> _obj;
    //    public static Int32 count = 0;

    //    private MyClass()
    //    {
    //        //Console.WriteLine(MyClass.count);
    //    }


    //    public static List<MyClass> singleObj
    //    {

    //        get
    //        {

    //            if (count <= 2)
    //            {
    //                _obj.Add(new MyClass());
    //                count++;
    //            }

    //            return _obj;
    //        }
    //    }

    //    public static MyClass getIndexedObj(int index = 0)
    //    {
    //        Console.WriteLine(_obj.Count);
    //        return _obj[index];
    //    }

    //    public void Main1()
    //    {
    //        Console.WriteLine("Hello World!");
    //    }

    //}

    //public class ClassLibrary2Class2 : Class1
    //{

    //    public void foo()
    //    {

    //        Class1 obj = new Class1();
    //        Console.WriteLine(obj.publicInt);
    //        //Console.WriteLine(obj.internalInt);   "internal" not accessible
    //        //Console.WriteLine(obj.protectedInternalInt); "protectedInternal" not accessible

    //        Console.WriteLine(publicInt);
    //        Console.WriteLine(protectedInt);
    //        //Console.WriteLine(internalInt);   "internal" not accessible
    //        //Console.WriteLine(privateProtectedInt);   "Private Protected" not accessible
    //        Console.WriteLine(protectedInternalInt);
    //    }

    //}
}
