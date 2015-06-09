using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusinessLayer;

namespace QuidditchManagerWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StadiumClicked(object sender, RoutedEventArgs e)
        {
            StadiumWindow stadiumWindow = new StadiumWindow();
            stadiumWindow.Show();
        }

        private void GoalKeeperClicked(object sender, RoutedEventArgs e)
        {
            GoalKeeperWindow goalKeeperWindow = new GoalKeeperWindow();
            goalKeeperWindow.Show();
        }

        private void CatcherClicked(object sender, RoutedEventArgs e)
        {
            CatcherWindow catcherWindow = new CatcherWindow();
            catcherWindow.Show();
        }

        private void AvailablePlacesClicked(object sender, RoutedEventArgs e)
        {
            int selectedIndex = matchList.SelectedIndex;
            if (selectedIndex != -1)
            {
                AvailablePlacesWindow availablePlacesWindow = new AvailablePlacesWindow(selectedIndex);
                availablePlacesWindow.Show();
            }
        }
    }

    public class Matchees : ObservableCollection<string>
    {
        public Matchees()
        {
            MatchManager matchManager = new MatchManager();
            IEnumerable<string> listMatch = matchManager.GetMatchesOrderedByDate();
            foreach (string match in listMatch)
            {
                Add(match);
            }
        }
    }
}
