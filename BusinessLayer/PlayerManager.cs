using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class PlayerManager
    {
        public IEnumerable<string> GetCatchers()
        {
            List<string> players = new List<string>();

            IMatchManager matchManager = new MatchStubManager();
            List<IMatch> matches = matchManager.GetMatches();

            var matchQuery =
                from match in matches
                select match.Team1.Players;
            matchQuery.Concat(from match in matches select match.Team2.Players);
            foreach (List<IPlayer> list in matchQuery)
            {
                foreach (IPlayer player in list)
                {
                    if (!players.Contains(player.ToString()) && player.Status == Status.Catcher)
                        players.Add(player.ToString());
                }
            }

            return players;
        }

        public IEnumerable<string> GetGoalkeepers()
        {
            IPlayerManager playerManager = new PlayerStubManager();
            List<IPlayer> players = playerManager.GetPlayers();

            var playerQuery =
                from player in players
                where player.Status == Status.Goalkeeper && player.Birthday > new DateTime(DateTime.Now.Year - 17 , DateTime.Now.Month, DateTime.Now.Day)
                select player.ToString();
            
            return playerQuery;
        }
    }
}
