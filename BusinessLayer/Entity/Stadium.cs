using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entity
{
    public class Stadium : IStadium
    {
        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Stadium()
        {

        }

        public Stadium(String name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
