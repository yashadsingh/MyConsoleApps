using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Dictionary
    {
        static public void CallMe()
        {

            // sorts by key.
            SortedDictionary<string, string> myDr =
            new SortedDictionary<string, string>();
            myDr.Add("A", "A");
            myDr.Add("C", "B");
            myDr.Add("B", "C");

            // Display the key/value pairs
            foreach (KeyValuePair<string, string> pair in myDr)
            {
                Console.WriteLine("Key: {0} and Value: {1}",
                                    pair.Key, pair.Value);
            }
        }
    }
}
