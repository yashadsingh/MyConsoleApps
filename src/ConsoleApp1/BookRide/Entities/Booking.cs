using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BookRide.Entities
{
    public class Booking: Ride
    {
        internal int bookingId { get; set; }
        internal int offerId { get; set; }
        internal int riderId { get; set; }
       
    }
}
