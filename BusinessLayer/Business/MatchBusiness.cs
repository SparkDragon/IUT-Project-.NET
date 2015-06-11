using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessLayer.Manager;

namespace BusinessLayer
{
    public class MatchBusiness
    {
        public IEnumerable<string> GetMatchesOrderedByDate()
        {
            MatchManager matchManager = MatchManager.GetInstance();
            List<IMatch> matches = matchManager.GetMatches();
            IEnumerable<string> matchQuery = 
                from match in matches
                where match.MatchDate > DateTime.Now
                orderby match.MatchDate ascending
                select match.ToString();
            return matchQuery;
        }

        public string GetAvailablePlaces(int index)
        {
            MatchManager matchManager = MatchManager.GetInstance();
            List<IMatch> matches = matchManager.GetMatches();
            List<ISpectator> spectators = new List<ISpectator>();

            if (index >= matches.Count || index < 0)
                return null;

            IMatch match = matches[index];

            var placeQuery =
                from m in matches
                where m == match
                select m.Stadium.PlacesNumber - m.Spectators.Count;
            foreach (int placeNumber in placeQuery)
            {
                return placeNumber.ToString();
            }
            return "";
        }
    }
}
