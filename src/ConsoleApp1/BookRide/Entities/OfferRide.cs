using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BookRide.Entities
{
    public class OfferRide: Ride
    {
        internal int offerId { get; set; }
        internal int driverId { get; set; }

    }
}
