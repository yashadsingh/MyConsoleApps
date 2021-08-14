using ConsoleApp1.BookRide.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BookRide.Storage
{
    public static class BookingStore
    {
        internal static IList<Booking> bookingStore = new List<Booking>();
        internal static IList<OfferRide> offerRideStore = new List<OfferRide>();

        internal static void CreateRide(int id, int origin, int destination, int seats, int riderId)
        {
            var currentBooking = new Booking()
            {
                bookingId = id,
                origin = origin,
                destination = destination,
                seats = seats,
                riderId = riderId
            };

            bookingStore.Add(currentBooking);

        }

        internal static void ModifyRide(int id, int origin, int destination, int seats)
        {
            var currentBooking = bookingStore.FirstOrDefault(b => b.bookingId == id);
            currentBooking.origin = origin;
            currentBooking.destination = destination;
            currentBooking.seats = seats;
        }

        internal static void WithdrawRide(int id)
        {
            var currentBooking = bookingStore.FirstOrDefault(b => b.bookingId == id);
            bookingStore.Remove(currentBooking);
        }

        internal static decimal CompleteRide(int id)
        {
            var currentBooking = bookingStore.FirstOrDefault(b => b.bookingId == id);
            bookingStore.Remove(currentBooking);

            return (currentBooking.destination - currentBooking.origin) * 70;
        }

        internal static void CreateOfferRide(int id, int origin, int destination, int seats, int driverId)
        {
            var offerRide = new OfferRide()
            {
                offerId = id,
                origin = origin,
                destination = destination,
                seats = seats,
                driverId = driverId
            };

            offerRideStore.Add(offerRide);

        }

        internal static void ModifyOfferRide(int id, int origin, int destination, int seats)
        {
            var currentOfferRide = offerRideStore.FirstOrDefault(b => b.offerId == id);
            currentOfferRide.origin = origin;
            currentOfferRide.destination = destination;
            currentOfferRide.seats = seats;
        }

    }
}
