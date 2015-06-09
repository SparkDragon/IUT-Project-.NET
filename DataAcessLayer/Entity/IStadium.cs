using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IStadium
    {
        String Address
        {
            get;
            set;
        }

        int PlacesNumber
        {
            get;
            set;
        }

        String Name
        {
            get;
            set;
        }
    }
}
