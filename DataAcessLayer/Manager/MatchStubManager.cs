using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MatchStubManager : IMatchManager
    {
        public List<IMatch> GetMatches()
        {
            List<IMatch> matches = new List<IMatch>();

            MatchFactory matchFactory = new MatchFactory();
            
            TeamStubManager teamStubManager = new TeamStubManager();
            CupStubManager cupStubManager = new CupStubManager();
            StadiumStubManager stadiumStubManager = new StadiumStubManager();
            RefereeStubManager refereeStubManager = new RefereeStubManager();
            SpectatorStubManager spectatorStubManager = new SpectatorStubManager();

            List<ITeam> teams = teamStubManager.GetTeams();
            List<ICup> cups = cupStubManager.GetCups();
            List<IStadium> stadiums = stadiumStubManager.GetStadiums();
            List<IReferee> referees = refereeStubManager.GetReferees();
            List<ISpectator> spectators = spectatorStubManager.GetSpectators();

            matches.Add(matchFactory.GetMatch(teams[0], teams[1], stadiums[0], referees[0], 10, 5, cups[0], new DateTime(2016, 01, 01), spectators));
            matches.Add(matchFactory.GetMatch(teams[1], teams[0], stadiums[1], referees[1], 1, 80, cups[1], new DateTime(2016, 03, 01), spectators));
            matches.Add(matchFactory.GetMatch(teams[0], teams[1], stadiums[1], referees[0], 2, 7, cups[2], new DateTime(2016, 02, 01), spectators));

            return matches;
        }
    }
}
