using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class TeamStubManager : ITeamManager
    {
        public List<ITeam> GetTeams()
        {
            List<ITeam> teams = new List<ITeam>();

            TeamFactory teamFactory = new TeamFactory();
            PlayerStubManager playerStubManager = new PlayerStubManager();

            List<IPlayer> players = playerStubManager.GetPlayers();

            List<IPlayer> playerTeam1 = new List<IPlayer>();
            List<IPlayer> playerTeam2 = new List<IPlayer>();

            playerTeam1.Add(players[0]);
            playerTeam1.Add(players[1]);
            playerTeam1.Add(players[2]);

            playerTeam2.Add(players[3]);
            playerTeam2.Add(players[4]);
            
            teams.Add(teamFactory.GetTeam("Crispy tenders", playerTeam1));
            teams.Add(teamFactory.GetTeam("Fatmen", playerTeam2));

            return teams;
        }
    }
}
