using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class PlayerFactory
    {
        public IPlayer GetPlayer()
        {
            return new Player();
        }

        public IPlayer GetPlayer(String firstName, String lastName, DateTime birthday, int number, Status status, bool captain)
        {
            return new Player(firstName, lastName, birthday, number, status, captain);
        }
    }
}
