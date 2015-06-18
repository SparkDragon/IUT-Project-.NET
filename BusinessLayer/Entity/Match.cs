using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer.Entity
{
    public class Match : IMatch
    {
        private ITeam _team1;
        private ITeam _team2;
        private IStadium _stadium;
        private IReferee _referee;
        private int _team1Score;
        private int _team2Score;
        private ICup _cup;
        private DateTime _matchDate;

        public ITeam Team1
        {
            get
            {
                return _team1;
            }
            set
            {
                _team1 = value;
            }
        }

        public ITeam Team2
        {
            get
            {
                return _team2;
            }
            set
            {
                _team2 = value;
            }
        }

        public IStadium Stadium
        {
            get
            {
                return _stadium;
            }
            set
            {
                _stadium = value;
            }
        }

        public IReferee Referee
        {
            get
            {
                return _referee;
            }
            set
            {
                _referee = value;
            }
        }

        public int Team1Score
        {
            get
            {
                return _team1Score;
            }
            set
            {
                _team1Score = value;
            }
        }

        public int Team2Score
        {
            get
            {
                return _team2Score;
            }
            set
            {
                _team2Score = value;
            }
        }

        public ICup Cup
        {
            get { return _cup; }
            set { _cup = value; }
        }

        public DateTime MatchDate
        {
            get
            {
                return _matchDate;
            }
            set
            {
                _matchDate = value;
            }
        }

        public Match()
        {
        }

        public Match(ITeam team1, ITeam team2, IStadium nStadium, IReferee nReferee, int team1Score, int team2Score, ICup cup, DateTime matchDate)
        {
            Team1 = team1;
            Team2 = team2;
            Stadium = nStadium;
            Referee = nReferee;
            Team1Score = team1Score;
            Team2Score = team2Score;
            Cup = cup;
            MatchDate = matchDate;
        }

        public override string ToString()
        {
            return Team1 + " vs " + Team2 + ", " + MatchDate;
        }

        public override bool Equals(Object o)
        {
            Match match = (Match)o;
            return (Team1.Equals(match.Team1) && Team2.Equals(match.Team2) && MatchDate.Equals(match.MatchDate));
        }
    }
}
