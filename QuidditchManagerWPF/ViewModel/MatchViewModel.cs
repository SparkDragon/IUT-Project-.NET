using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfArtistesViewer.ViewModel;
using BusinessLayer.Entity;

namespace QuidditchManagerWPF.ViewModel
{
    public class MatchViewModel : ViewModelBase
    {
        private IMatch _match;

        public IMatch Match
        {
            get { return _match; }
            private set { _match = value; }
        }

        public MatchViewModel(IMatch matchModel)
        {
            _match = matchModel;
        }

        public string Team1
        {
            get { return _match.Team1.Name; }
            set
            {
                if (value == _match.Team1.Name) return;
                _match.Team1.Name = value;
                base.OnPropertyChanged("Team1");
            }
        }

        public string Team2
        {
            get { return _match.Team2.Name; }
            set
            {
                if (value == _match.Team2.Name) return;
                _match.Team2.Name = value;
                base.OnPropertyChanged("Team2");
            }
        }

        public string Stadium
        {
            get { return _match.Stadium.Name; }
            set
            {
                if (value == _match.Stadium.Name) return;
                _match.Stadium.Name = value;
                base.OnPropertyChanged("Stadium");
            }
        }

        public string Referee
        {
            get { return _match.Referee.LastName; }
            set
            {
                if (value == _match.Referee.LastName) return;
                _match.Referee.LastName = value;
                base.OnPropertyChanged("Referee");
            }
        }

        public int Cup
        {
            get { return _match.Cup.CupYear; }
            set
            {
                if (value == _match.Cup.CupYear) return;
                _match.Cup.CupYear = value;
                base.OnPropertyChanged("Cup");
            }
        }

        public int Team1Score
        {
            get { return _match.Team1Score; }
            set
            {
                if (value == _match.Team1Score) return;
                _match.Team1Score = value;
                base.OnPropertyChanged("Team1Score");
            }
        }

        public int Team2Score
        {
            get { return _match.Team2Score; }
            set
            {
                if (value == _match.Team2Score) return;
                _match.Team2Score = value;
                base.OnPropertyChanged("Team2Score");
            }
        }

        public DateTime MatchDate
        {
            get { return _match.MatchDate; }
            set
            {
                if (value == _match.MatchDate) return;
                _match.MatchDate = value;
                base.OnPropertyChanged("MatchDate");
                base.OnPropertyChanged("MatchDateFormat");
            }
        }

        public String MatchDateFormat
        {
            get { return _match.MatchDate.ToShortDateString(); }
        }
    }
}
