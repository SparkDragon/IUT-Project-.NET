using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IMatch
    {
        ITeam Team1
        {
            get;
            set;
        }
        ITeam Team2
        {
            get;
            set;
        }
        IStadium Stadium
        {
            get;
            set;
        }
        IReferee Referee
        {
            get;
            set;
        }
        int Team1Score
        {
            get;
            set;
        }
        int Team2Score
        {
            get;
            set;
        }
        ICup Cup
        {
            get;
            set;
        }
        DateTime MatchDate
        {
            get;
            set;
        }
        List<ISpectator> Spectators
        {
            get;
            set;
        }
    }
}
