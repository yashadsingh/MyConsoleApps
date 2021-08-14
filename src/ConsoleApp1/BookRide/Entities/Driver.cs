using ConsoleApp1.BookRide.Contracts;
using ConsoleApp1.BookRide.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BookRide.Entities
{
    public class Driver : Person, ICompleteRide
    {
        internal int driverId { get; set; }

        internal Driver(string fullName):base(fullName)
        {
            driverId = new Random().Next();
        }

        public void CreateRide(int id, int origin, int destination, int seats)
        {
            BookingStore.CreateOfferRide(id, origin, destination, seats, driverId);
        }

        public void ModifyRide(int id, int origin, int destination, int seats)
        {
            BookingStore.ModifyOfferRide(id, origin, destination, seats);
        }

        decimal ICompleteRide.CompleteRide(int id)
        {
            return BookingStore.CompleteRide(id);
        }

    }
}
