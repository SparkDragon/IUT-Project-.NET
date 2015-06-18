using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entity
{
    public class Cup : ICup
    {
        private int _year;

        public int CupYear
        {
            get { return _year; }
            set { _year = value; }
        }

        public Cup()
        {

        }

        public Cup(int year)
        {
            CupYear = year;
        }
    }
}
