using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class RoughWork
    {

        //public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        //{
        //    SortedSet<int> set1 = new SortedSet<int>();

        //    var temp = nums1.Concat(nums2).OrderBy(x => x).ToArray();
        //    temp.Count();
        //    int[] ss = new int[1];

        //}
            public static void CallMe()
        {
            string s = "abccdefgh";
            int length = s.Length;
            0.9
            double dbl = 0.1d;
            decimal dcml = 0.1m;
            float flt = 0.1f;

            HashSet<int> chars = new HashSet<int>(new int[]{1,2,3,1,2,3,4});
            chars.ToArray<int>().OrderBy(x => x);

            List<int> dd = new List<int>(new int[]{1,2 });
            var ff= new List<int>(new int[] { 1, 2 ,3});

            var dfdf= ff.Concat(dd);

            int answer = 0, i = 0, j = 0;

            while (i < length && j < length)
            {
                if (chars.Add(s[j]))
                {
                    j++;
                    answer = Math.Max(answer, j - i);
                }
                else
                {
                    chars.Remove(s[i++]);
                }
            }

            Console.WriteLine(answer);
        }


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
