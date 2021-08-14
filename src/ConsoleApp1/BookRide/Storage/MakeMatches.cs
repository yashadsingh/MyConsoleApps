using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BookRide.Storage
{
    public class MakeMatches
    {
        private readonly Object obj = new Object();

        internal void BookMyRide(int bookingId)
        {
            lock(obj)
            {
                var booking = BookingStore.bookingStore.FirstOrDefault(x=> x.bookingId == bookingId);
                var offerRide = BookingStore.offerRideStore.FirstOrDefault(x => x.seats >= booking.seats && x.origin <= booking.origin && x.destination >= booking.destination);
                
                if (offerRide == null)
                    Console.WriteLine($"No rider available for rider id: {booking.riderId}");

                offerRide.seats = offerRide.seats - booking.seats;
                booking.offerId = offerRide.offerId;
                
                //Console.WriteLine($"Ride confirmed with driver Id: {offerRide.driverId}  for rider Id: {booking.riderId}");

            }

        }

    }
}
