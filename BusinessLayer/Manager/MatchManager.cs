using DataAccessLayer;
using DataAcessLayer.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Manager
{
    public class MatchManager
    {
        private static MatchManager instance;

        private MatchManager()
        {

        }

        public static MatchManager GetInstance()
        {
            if (instance == null)
                instance = new MatchManager();
            return instance;
        }

        public List<IMatch> GetMatches ()
        {
            IMatchManager matchManager = new MatchSqlManager();
            return matchManager.GetMatches();
        }
    }
}
