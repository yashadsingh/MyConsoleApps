using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class LongestPalindrome
    {

        // Function to print a subString str[low..high]
        static void printSubStr(String str, int low, int high)
        {
            for (int i = low; i <= high; ++i)
                Console.Write(str[i]);
        }

        // This function prints the
        // longest palindrome subString
        // It also returns the length
        // of the longest palindrome
        static int longestPalSubstr(String str)
        {
            // get length of input String
            int n = str.Length;

            // All subStrings of length 1
            // are palindromes
            int maxLength = 1, start = 0;

            // Nested loop to mark start and end index
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i; j < str.Length; j++)
                {
                    int flag = 1;

                    // Check palindrome
                    for (int k = 0; k < (j-i+1) / 2; k++)
                        if (str[i+k] != str[j - k])
                            flag = 0;

                    // Palindrome
                    if (flag != 0 && (j - i + 1) > maxLength)
                    {
                        start = i;
                        maxLength = j - i + 1;
                    }
                }
            }

            Console.Write("longest palindrome subString is: ");
            printSubStr(str, start, start + maxLength - 1);

            // return length of LPS
            return maxLength;
        }

        // Driver Code
        public static void CallMe()
        {
            String str = "forgeeksskeegfor";
            Console.Write("\nLength is: "
                 + longestPalSubstr(str));
        }
    }
}
