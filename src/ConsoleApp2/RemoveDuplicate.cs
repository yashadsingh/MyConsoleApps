using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class RemoveDuplicate
    {

        static String removeDuplicate(char[] str, int n)
        {
            // Used as index in the modified string 
            int index = 0;

            // Traverse through all characters 
            for (int i = 0; i < n; i++)
            {

                // Check if str[i] is present before it  
                int j;
                for (j = 0; j < i; j++)
                {
                    if (str[i] == str[j])
                    {
                        break;
                    }
                }

                // If not present, then add it to 
                // result. 
                if (j == i)
                {
                    str[index++] = str[i];
                }
            }
            char[] ans = new char[index];
            Array.Copy(str, ans, index);
            return String.Join("", ans);
        }

        public static int removeDuplicateElements(int[] arr, int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            int[] temp = new int[n];
            int j = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    temp[j++] = arr[i];
                }
            }
            temp[j++] = arr[n - 1];
            // Changing original array  
            for (int i = 0; i < j; i++)
            {
                arr[i] = temp[i];
            }
            return j;
        }

    }
}
