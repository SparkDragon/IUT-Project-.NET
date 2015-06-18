using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entity
{
    public class Referee : IReferee
    {
        private String _firstName;

        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private String _lastName;

        public String LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public Referee()
        {

        }

        public Referee(String firstName, String lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
