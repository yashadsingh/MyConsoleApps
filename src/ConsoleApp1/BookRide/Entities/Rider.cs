using ConsoleApp1.BookRide.Contracts;
using ConsoleApp1.BookRide.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BookRide.Entities
{
    class Rider : Person, ICreateRide, IWithdrawRide
    {
        internal int riderId { get; set; }

        internal Rider(string fullname):base(fullname)
        {
            riderId = new Random().Next();
        }

        public void CreateRide(int id, int origin, int destination, int seats)
        {
            BookingStore.CreateRide(id, origin, destination, seats, riderId);
        }

        public void ModifyRide(int id, int origin, int destination, int seats)
        {
            BookingStore.ModifyRide(id, origin, destination, seats);
        }

        void IWithdrawRide.WithdrawRide(int id)
        {
            BookingStore.WithdrawRide(id);
        }
    }
}
