using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Entity;
using BusinessLayer.Manager;

namespace BusinessLayer.ViewModel
{
    public class MatchBusinessViewModel
    {
        public IEnumerable<IMatch> GetMatchesOrderedByDate()
        {
            MatchManager matchManager = MatchManager.GetInstance();
            IMatch matchBusiness;
            ITeam team1;
            ITeam team2;
            IReferee referee;
            IStadium stadium;
            ICup cup;
            List<IMatch> matchesBusiness = new List<IMatch>();

            List<DataAccessLayer.IMatch> matches = matchManager.GetMatches();
            foreach (DataAccessLayer.IMatch match in matches)
            {

                team1 = new Team(match.Team1.Name);
                team2 = new Team(match.Team2.Name);
                referee = new Referee(match.Referee.FirstName, match.Referee.LastName);
                stadium = new Stadium(match.Stadium.Name);
                cup = new Cup(match.Cup.CupYear);

                matchBusiness = new Match(team1, team2, stadium, referee, match.Team1Score, match.Team2Score, cup, match.MatchDate);
                matchesBusiness.Add(matchBusiness);
            }

            IEnumerable<IMatch> matchQuery =
                from match in matchesBusiness
                where match.MatchDate > DateTime.Now
                orderby match.MatchDate ascending
                select match;
            return matchQuery;
        }
    }
}
