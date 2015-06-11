using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessLayer.Manager;

namespace BusinessLayer
{
    public class StadiumBusiness
    {
        public IEnumerable<string> GetStadiums()
        {
            StadiumManager stadiumManager = StadiumManager.GetInstance();
            List<IStadium> stadiums = stadiumManager.GetStadiums();
            List<string> stringStadiums = new List<string>();

            MatchManager matchManager = MatchManager.GetInstance();
            List<IMatch> matches = matchManager.GetMatches();
            var stadiumQuery =
                from match in matches
                select match.Stadium.ToString();

            return stadiumQuery.Distinct();
        }
    }
}
