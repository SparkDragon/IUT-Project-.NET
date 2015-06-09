using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class BookingFactory
    {
        public IBooking GetBooking()
        {
            return new Booking();
        }

        public IBooking GetBooking(int price, IMatch match, int placesNumber)
        {
            return new Booking(price, match, placesNumber);
        }
    }
}
