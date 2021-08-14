using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BookRide.Entities
{
    public class Person
    {
        internal string name { get; set; }

        internal Person(string fullName)
        {
            name = fullName;
        }

    }
}
