using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class Stadium : IStadium
    {
        private String _address;

        public String Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private int _placesNumber;

        public int PlacesNumber
        {
            get { return _placesNumber; }
            set { _placesNumber = value; }
        }

        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Stadium()
        {

        }

        public Stadium(String address, int placesNumber, String name)
        {
            Address = address;
            PlacesNumber = placesNumber;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
