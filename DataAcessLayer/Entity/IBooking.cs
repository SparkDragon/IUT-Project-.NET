using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IBooking
    {
        int Price
        {
            get;
            set;
        }
        IMatch Match
        {
            get;
            set;
        }
        int PlacesNumber
        {
            get;
            set;
        }
    }
}
