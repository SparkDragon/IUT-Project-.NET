using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class RefereeStubManager : IRefereeManager
    {
        public List<IReferee> GetReferees()
        {
            List<IReferee> referees = new List<IReferee>();

            RefereeFactory refereeFactory = new RefereeFactory();

            referees.Add(refereeFactory.GetReferee("Jordan", "Cros", new DateTime(1993, 04, 08), 154));
            referees.Add(refereeFactory.GetReferee("Sebastien", "Salva", new DateTime(1970, 01, 01), 124));

            return referees;
        }
    }
}
