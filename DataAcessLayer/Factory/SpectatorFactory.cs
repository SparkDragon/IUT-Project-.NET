using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class SpectatorFactory
    {
        public ISpectator GetSpectator()
        {
            return new Spectator();
        }

        public ISpectator GetSpectator(String firstName, String lastName, DateTime birthday, String address, String mail)
        {
            return new Spectator(firstName, lastName, birthday, address, mail);
        }
    }
}
