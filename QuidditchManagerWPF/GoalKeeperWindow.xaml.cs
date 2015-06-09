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
using System.Windows.Shapes;
using BusinessLayer;

namespace QuidditchManagerWPF
{
    /// <summary>
    /// Interaction logic for GoalKeeperWindow.xaml
    /// </summary>
    public partial class GoalKeeperWindow : Window
    {
        public GoalKeeperWindow()
        {
            InitializeComponent();
        }
    }

    public class GoalKeepers : ObservableCollection<string>
    {
        public GoalKeepers()
        {
            PlayerManager playerManager = new PlayerManager();
            IEnumerable<string> listGoalkeeper = playerManager.GetGoalkeepers();
            foreach (string goalkeeper in listGoalkeeper)
            {
                Add(goalkeeper);
            }
        }
    }
}
