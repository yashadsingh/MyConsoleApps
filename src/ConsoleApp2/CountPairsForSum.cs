﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CountPairsForSum
    {
        public static int[] arr = new int[] { 1, 5, 7,3,3,6,0, -1, 5 };

        // Returns number of pairs in arr[0..n-1]
        // with sum equal to 'sum'
        public static int getPairsCount(int n, int sum)
        {
            Dictionary<int, int> hm
                = new Dictionary<int, int>();

            // Store counts of all elements
            // in map hm
            for (int i = 0; i < n; i++)
            {

                // initializing value to 0,
                // if key not found
                if (!hm.ContainsKey(arr[i]))
                {
                    hm[arr[i]] = 0;
                }

                hm[arr[i]] = hm[arr[i]] + 1;
            }
            int twice_count = 0;

            // iterate through each element and
            // increment the count (Notice that
            // every pair is counted twice)
            for (int i = 0; i < n; i++)
            {
                if (hm[sum - arr[i]] != 0)
                {
                    twice_count += hm[sum - arr[i]];
                }

                // if (arr[i], arr[i]) pair satisfies
                // the condition, then we need to ensure
                // that the count is decreased by one
                // such that the (arr[i], arr[i])
                // pair is not considered
                if (sum - arr[i] == arr[i])
                {
                    twice_count--;
                }
            }

            // return the half of twice_count
            return twice_count / 2;
        }

        // Driver Code
        public static void CallMe()
        {
            int sum = 6;
            Console.WriteLine("Count of pairs is "
                              + getPairsCount(arr.Length, sum));
           
        }
    }
}
