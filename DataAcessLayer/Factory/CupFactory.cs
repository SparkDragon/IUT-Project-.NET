using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class CupFactory
    {
        public ICup GetCup()
        {
            return new Cup();
        }

        public ICup GetCup(int year)
        {
            return new Cup(year);
        }
    }
}
