using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Anagram
    {

        public static Boolean check(char[] str1, char[] str2)
        {

            int count = 0;

            if (str1.Length != str2.Length)
                return false;

            for (int i = 0; i < str1.Length; i++)
            {
                bool IsComplete = false;
                for (int j = 0; i < str2.Length; j++)
                {
                    if (str2[j] == str1[i])
                    {
                        str1[i] = '1';
                        str2[j] = '1';
                        IsComplete = true;
                        count++;
                        break;
                    }
                }
                if (!IsComplete)
                    return false;
            }
            if (count == str1.Length)
                return true;

            return true;
        }
    }
}