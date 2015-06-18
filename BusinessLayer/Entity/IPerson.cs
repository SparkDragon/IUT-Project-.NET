using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entity
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
    }
}
