using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IPerson
    {
        String FirstName
        {
            get;
            set;
        }
        String LastName
        {
            get;
            set;
        }
        DateTime Birthday
        {
            get;
            set;
        }
    }
}
