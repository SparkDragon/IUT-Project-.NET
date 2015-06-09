using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class RefereeFactory
    {
        public IReferee GetReferee()
        {
            return new Referee();
        }

        public IReferee GetReferee(String firstName, String lastName, DateTime birthday, int lifeInsurancePolicyNumber)
        {
            return new Referee(firstName, lastName, birthday, lifeInsurancePolicyNumber);
        }
    }
}
