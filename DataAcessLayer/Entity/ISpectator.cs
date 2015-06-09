using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface ISpectator : IPerson
    {
        String Address
        {
            get;
            set;
        }
        String Mail
        {
            get;
            set;
        }
    }
}
