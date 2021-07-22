using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CoinChange
    {

        public static int count(int[] S, int n, int sum)
        {
            Dictionary<int, int> hm = new Dictionary<int, int>();
            var d = sum % 2;

            for (int i = 0; i < n; i++)
            {
                if (sum % S[i] != sum)
                {
                    hm[S[i]] = (sum % S[i] == 0 ? sum / 2 : (sum - sum % S[i]) / S[i]);
                }

            }

            int size = hm.Values.Sum();
            int[] arr_sec = new int[size];
            int maxcount = 0;
            int index = 0;

            for (int j = 0; j < n; j++)
            {
                maxcount = hm[S[j]];

                while (maxcount > 0)
                {
                    arr_sec[index] = S[j];
                    maxcount--;
                    index++;
                }
            }
               


            return 1;
        }

        public static void CallMe()
        {

            int[] arr = { 1, 2, 3 };
            int m = arr.Length;
            Console.Write(count(arr, m, 4));


        }
    }
}
