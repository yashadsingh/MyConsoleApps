using ConsoleApp1.BookRide.Entities;
using ConsoleApp1.BookRide.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BookRide
{
    public class TestMe
    {
        public static void CallMe()
        {

            Driver driver1 = new Driver("Mukesh Bisht");
            driver1.CreateRide(1,10,20,4);

            Driver driver2 = new Driver("Abhinav Maheshwari");
            driver2.CreateRide(2,30,40,4);
            
            Driver driver3 = new Driver("Vijay");
            driver3.CreateRide(3,50,60,4);
            
            Driver driver4 = new Driver("Akshay");
            driver4.CreateRide(4, 70, 80, 4);

            ///////////////////////////////////////////////////

            Rider rider1 = new Rider("Priya");
            rider1.CreateRide(1, 10, 20, 3);

            Rider rider2 = new Rider("Mohini");
            rider2.CreateRide(2, 30, 40, 1);

            Rider rider3 = new Rider("Renu");
            rider3.CreateRide(3, 50, 60, 4);
            
            Rider rider4 = new Rider("Manpreet");
            rider4.CreateRide(4, 70, 80, 2);

            var dd = BookingStore.bookingStore;
            var dddd = BookingStore.offerRideStore;
            
            MakeMatches makeMatches = new MakeMatches();
            makeMatches.BookMyRide(1);

            Console.WriteLine($"Ride completed. Kindly Pay CASH Rs. {BookingStore.CompleteRide(1)}");

        }
    }
}
