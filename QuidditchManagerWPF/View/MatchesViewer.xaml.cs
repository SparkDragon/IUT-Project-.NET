using System;
using System.Collections.Generic;
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

namespace QuidditchManagerWPF.View
{
    /// <summary>
    /// Logique d'interaction pour MatchesViewer.xaml
    /// </summary>
    public partial class MatchesViewer : Window
    {
        public MatchesViewer()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MatchesViewModel msvm = new MatchesViewModel();
            msvm.CloseNotified += CloseNotified;
            ucMatches.DataContext = msvm;
        }

        private void CloseNotified(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MatchesViewModel mvm = null;

            mvm = (MatchesViewModel)ucMatches.DataContext;
            if (mvm != null) mvm.CloseNotified -= CloseNotified;
        }
    }
}
