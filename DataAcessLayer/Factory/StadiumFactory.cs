using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class StadiumFactory
    {
        public IStadium GetStadium()
        {
            return new Stadium();
        }

        public IStadium GetStadium(String address, int placesNumber, String name)
        {
            return new Stadium(address, placesNumber, name);
        }
    }
}
