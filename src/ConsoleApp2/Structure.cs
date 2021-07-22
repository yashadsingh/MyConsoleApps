using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Structure
    {
        static void StructEventHandler(int point)
        {
            Console.WriteLine("Coordinate changed to {0}", point);
        }
    }

    struct Coordinate
    {
        private int _x, _y;

        public int x
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
                CoordinatesChanged(_x);
            }
        }

        public int y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
                CoordinatesChanged(_y);
            }
        }

        public event Action<int> CoordinatesChanged;
    }

}
