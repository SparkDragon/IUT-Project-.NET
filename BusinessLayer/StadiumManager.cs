using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class StadiumManager
    {
        public IEnumerable<string> GetStadiums()
        {
            IStadiumManager stadiumManager = new StadiumStubManager();
            List<IStadium> stadiums = stadiumManager.GetStadiums();
            List<string> stringStadiums = new List<string>();
                        
            IMatchManager matchManager = new MatchStubManager();
            List<IMatch> matches = matchManager.GetMatches();
            var stadiumQuery =
                from match in matches
                select match.Stadium.ToString();

            return stadiumQuery.Distinct();
        }
    }
}
