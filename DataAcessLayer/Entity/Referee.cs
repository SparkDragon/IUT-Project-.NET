using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class Referee : IReferee
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

        private DateTime _birthday;

        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        private int _lifeInsurancePolicyNumber;

        public int LifeInsurancePolicyNumber
        {
            get { return _lifeInsurancePolicyNumber; }
            set { _lifeInsurancePolicyNumber = value; }
        }

        public Referee()
        {

        }

        public Referee(String firstName, String lastName, DateTime birthday, int lifeInsurancePolicyNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            LifeInsurancePolicyNumber = lifeInsurancePolicyNumber;
        }
    }
}
