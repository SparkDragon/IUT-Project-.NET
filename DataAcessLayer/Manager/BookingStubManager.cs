using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class BookingStubManager : IBookingManager
    {
        public List<IBooking> GetBookings()
        {
            MatchStubManager matchStubManager = new MatchStubManager();
            List<IMatch> matches = matchStubManager.GetMatches();

            List<IBooking> bookings = new List<IBooking>();

            bookings.Add(new Booking(10, matches[0], 1));
            bookings.Add(new Booking(20, matches[1], 1));
            bookings.Add(new Booking(15, matches[0], 2));

            return bookings;
        }
    }
}
