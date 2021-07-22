using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class LongestAltSequence
    {
        static int LAS(int[] arr, int n)
        {

            // "inc" and "dec" intialized as 1,
            // as single element is still LAS
            int inc = 1;
            int dec = 1;

            // Iterate from second element
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > arr[i - 1])
                {

                    // "inc" changes iff "dec"
                    // changes
                    inc = dec + 1;
                }
                else if (arr[i] < arr[i - 1])
                {

                    // "dec" changes iff "inc"
                    // changes
                    dec = inc + 1;
                }
            }

            // Return the maximum length
            return Math.Max(inc, dec);
        }

        // Driver code 
        public static void CallMe()
        {
            int[] arr = { 10, 22, 9, 33,
                  49, 50, 31, 60 };
            int n = arr.Length;

            // Function Call
            Console.WriteLine(LAS(arr, n));
        }
    }
}
