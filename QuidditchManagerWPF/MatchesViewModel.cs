using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Entity;
using BusinessLayer.ViewModel;
using QuidditchManagerWPF.ViewModel;
using WpfArtistesViewer.ViewModel;

namespace QuidditchManagerWPF
{
    public class MatchesViewModel : ViewModelBase
    {
        public event EventHandler<EventArgs> CloseNotified;
        protected void OnCloseNotified(EventArgs e)
        {
            this.CloseNotified(this, e);
        }

        private ObservableCollection<MatchViewModel> _matches;

        public ObservableCollection<MatchViewModel> Matches
        {
            get { return _matches; }
            private set
            {
                _matches = value;
                OnPropertyChanged("Matches");
            }
        }

        private MatchViewModel _selectedItem;
        public MatchViewModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public MatchesViewModel()
        {
            MatchBusinessViewModel matchManager = new MatchBusinessViewModel();
            IEnumerable<IMatch> listMatch = matchManager.GetMatchesOrderedByDate();
            _matches = new ObservableCollection<MatchViewModel>();
            foreach (Match m in listMatch)
            {
                _matches.Add(new MatchViewModel(m));
            }
        }

        // Commande Add
        private RelayCommand _addCommand;
        public System.Windows.Input.ICommand AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new RelayCommand(
                        () => this.Add(),
                        () => this.CanAdd()
                        );
                }
                return _addCommand;
            }
        }

        private bool CanAdd()
        {
            return true;
        }

        private void Add()
        {
            IMatch match = new Match(new Team("Team1"), new Team("Team2"), new Stadium("Stadium"), new Referee("Roger", "Dupont"), 0, 0, new Cup(2015), new DateTime());

            this.SelectedItem = new MatchViewModel(match);
            Matches.Add(this.SelectedItem);
        }

        // Commande Remove
        private RelayCommand _removeCommand;
        public System.Windows.Input.ICommand RemoveCommand
        {
            get
            {
                if (_removeCommand == null)
                {
                    _removeCommand = new RelayCommand(
                        () => this.Remove(),
                        () => this.CanRemove()
                        );
                }
                return _removeCommand;
            }
        }

        private bool CanRemove()
        {
            return (this.SelectedItem != null);
        }

        private void Remove()
        {
            if (this.SelectedItem != null) Matches.Remove(this.SelectedItem);
        }
    }
}
