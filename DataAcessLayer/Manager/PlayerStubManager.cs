using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PlayerStubManager : IPlayerManager
    {
        public List<IPlayer> GetPlayers()
        {
            List<IPlayer> players = new List<IPlayer>();

            PlayerFactory playerFactory = new PlayerFactory();

            players.Add(playerFactory.GetPlayer("Faris", "Tharic", new DateTime(1994, 12, 25), 1, Status.Catcher, true));
            players.Add(playerFactory.GetPlayer("Bruno", "Tettarassar", new DateTime(1994, 04, 12), 1, Status.Beater, false));
            players.Add(playerFactory.GetPlayer("Simon", "Tabaka", new DateTime(1994, 07, 07), 1, Status.Beater, false));
            players.Add(playerFactory.GetPlayer("Vincent", "Marius", new DateTime(1993, 04, 11), 1, Status.Tracker, false));
            players.Add(playerFactory.GetPlayer("Thomas", "Leduc", new DateTime(2012, 09, 09), 1, Status.Goalkeeper, false));

            return players;
        }
    }
}
