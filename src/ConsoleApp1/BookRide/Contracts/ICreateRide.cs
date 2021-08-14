using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BookRide.Contracts
{
    public interface ICreateRide
    {
        public void CreateRide(int id, int origin, int destination, int seats);
        public void ModifyRide(int id, int origin, int destination, int seats);
    }
}
