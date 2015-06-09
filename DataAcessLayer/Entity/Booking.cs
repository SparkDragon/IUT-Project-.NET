using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class Booking : IBooking
    {
        public int _price;
        public IMatch _match;
        public int _placesNumber;

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public IMatch Match
        {
            get
            {
                return _match;
            }
            set
            {
                _match = value;
            }
        }

        public int PlacesNumber
        {
            get
            {
                return _placesNumber;
            }
            set
            {
                _placesNumber = value;
            }
        }

        public Booking()
        {
        }

        public Booking(int price, IMatch match, int placesNumber)
        {
            Price = price;
            Match = match;
            placesNumber = placesNumber;
        }
    }
}
