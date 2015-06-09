using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class TeamFactory
    {
        public ITeam GetTeam()
        {
            return new Team();
        }

        public ITeam GetTeam(String name, List<IPlayer> players)
        {
            return new Team(name, players);
        }
    }
}
