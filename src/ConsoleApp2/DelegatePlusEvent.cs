using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    /// <summary>
    /// Custom Event Args
    /// </summary>
    public class CustomEventArgs : EventArgs
    {

        public CustomEventArgs(int param1, int param2, int param3, int param4)
        {
            Param1 = param1;
            Param2 = param2;
            Param3 = param3;
            Param4 = param4;
        }

        public int Param1 { get; set; }
        public int Param2 { get; set; }
        public int Param3 { get; set; }
        public int Param4 { get; set; }

    }

    /// <summary>
    /// Event and its definition
    /// </summary>
    public class DoWork
    {

        public event EventHandler<CustomEventArgs> DoWorkEvent;
        public event EventHandler CompletedWorkEvent;

        public void TrackTheWork(int param1, int param2, int param3, int param4)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                OnDoWorkEvent(param1, param2, param3, param4);
            }
            OnCompletedWorkEvent();
        }

        public void OnDoWorkEvent(int param1, int param2, int param3, int param4)
        {
            if (DoWorkEvent == null)
                Console.WriteLine("DoWorkEvent delegate is null");
            else
                DoWorkEvent(this, new CustomEventArgs(param1, param2, param3, param4));
        }

        public void OnCompletedWorkEvent()
        {
            if (CompletedWorkEvent == null)
                Console.WriteLine("CompletedWorkEvent delegate is null");
            else
                CompletedWorkEvent(this, EventArgs.Empty);
        }

    }

    public class DelegatePlusEvent
    {
        public static void CallMe()
        {
            DelegatePlusEvent obj = new DelegatePlusEvent();
            obj.TestMe();
        }

        public void TestMe()
        {
            DoWork obj = new DoWork();
            obj.DoWorkEvent += new EventHandler<CustomEventArgs>(DoWorkHandler);
            obj.CompletedWorkEvent += new EventHandler(CompletedWorkHandler);
            obj.TrackTheWork(1, 2, 3, 4);

            obj.OnDoWorkEvent(1, 2, 3, 4);
            //obj.OnCompletedWorkEvent();

        }

        public void DoWorkHandler(object sender, CustomEventArgs e)
        {
            Console.WriteLine("Doing the work...");
        }

        public void CompletedWorkHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Completed the work...");

        }

    }
}
