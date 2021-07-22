using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class FindOccurrences
    {

        public static void CallMe()
        {
            string[] strArr = { "five", "one", "five", "two", "three", "five" };
            int n = strArr.Count();
            string[] strArrItem = new string[n];// = { "five", "one", "five", "two", "three", "five" };
            int[] intArrItemCount = new int[6];
            int itemIndex = -1;
            //strArr.Count(x => x=="five");

            for (int i = 0; i < n; i++)
            {
                if (!string.IsNullOrWhiteSpace(strArr[i]))
                {
                    itemIndex++;
                    strArrItem[itemIndex] = strArr[i];
                    intArrItemCount[itemIndex] = 1;

                    for (int j = i + 1; j < n; j++)
                    {
                        if (strArr[i] == strArr[j])
                        {
                            intArrItemCount[itemIndex] = intArrItemCount[itemIndex] + 1;
                            strArr[j] = string.Empty;
                        }
                    }
                }
            }

            //for (int i = (n / 2); i < n; i++)
            //{
            //    if (!string.IsNullOrWhiteSpace(strArr[i]))
            //    {
            //        itemIndex++;
            //        strArrItem[itemIndex] = strArr[i];
            //        intArrItemCount[itemIndex] = 1;

            //        for (int j = i + 1; j < (n / 2 - 1); j++)
            //        {
            //            if (strArr[i] == strArr[j])
            //            {
            //                intArrItemCount[itemIndex] = intArrItemCount[itemIndex] + 1;
            //                strArr[j] = string.Empty;
            //            }
            //        }
            //    }
            //}

        }

    }
}
