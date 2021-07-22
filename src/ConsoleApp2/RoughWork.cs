using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class RoughWork
    {

        //    public interface IPluggable
        //    {
        //        Type InputType { get; }
        //        Type OutputType { get; }

        //        Object Handle(Object value);
        //    }

        //    public abstract class Pluggable<TInput, TOutput> : IPluggable
        //    {
        //        Type IPluggable.InputType { get { return typeof(TInput); } }
        //        Type IPluggable.OutputType { get { return typeof(TOutput); } }
        //        object IPluggable.Handle(object value)
        //        {

        //            return Handle((TInput)value);
        //        }

        //        protected abstract TOutput Handle(TInput value);
        //    }

        //    public static void CallMe() {


        //    }
        //}

        //public class Solution
        //{

        //    Dictionary<string, int> dynamicArr = new Dictionary<string, int>();

        //    public int MaxProfit(int[] prices)
        //    {

        //        int min = 0;
        //        int max = 0;

        //        for (int i = 0; i < len; i++)
        //        {
        //            if (prices[min] >= prices[i])
        //            {
        //                min = i;
        //            }
        //            else
        //            {
        //                max = i;
        //            }

        //            if (max > min)
        //            {
        //                MaxOutput(min, prices, len);

        //            }
        //        }

        //        MaxOutput(0, prices, prices.Length);
        //        if (dynamicArr.Values.Count() == 0)
        //            return 0;
        //        else
        //            return dynamicArr.Values.Max();
        //    }

        //    private int MaxOutput(int buyIndex, int[] prices, int len)
        //    {
        //        if (buyIndex == len - 1)
        //            return 0;

        //        int min = buyIndex;
        //        int max = buyIndex;

        //        for (int i = buyIndex; i < len; i++)
        //        {
        //            if (prices[min] >= prices[i])
        //            {
        //                min = i;
        //            }
        //            else
        //            {
        //                max = i;
        //            }

        //            if (max > min)
        //            {
        //                int result = (prices[max] - prices[min]) + MaxOutput(max + 1, prices, len);
        //                dynamicArr.Add(Guid.NewGuid().ToString(), result);
        //            }
        //        }

        //        return 0;

        //    }

    }



}
