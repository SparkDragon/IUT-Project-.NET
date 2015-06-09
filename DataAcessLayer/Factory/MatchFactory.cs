using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class MatchFactory
    {
        public IMatch GetMatch()
        {
            return new Match();
        }

        public IMatch GetMatch(ITeam team1, ITeam team2, IStadium nStadium, IReferee nReferee, int team1Score, int team2Score, ICup cup, DateTime matchDate, List<ISpectator> spectators)
        {
            return new Match(team1, team2, nStadium, nReferee, team1Score, team2Score, cup, matchDate, spectators);
        }
    }
}
