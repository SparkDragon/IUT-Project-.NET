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
    /// Logique d'interaction pour StadiumWindow.xaml
    /// </summary>
    public partial class StadiumWindow : Window
    {
        public StadiumWindow()
        {
            InitializeComponent();
        }
    }

    public class Stadiums : ObservableCollection<string>
    {
        public Stadiums()
        {
            StadiumBusiness stadiumManager = new StadiumBusiness();
            IEnumerable<string> listStadium = stadiumManager.GetStadiums();
            foreach (string stadium in listStadium)
            {
                Add(stadium);
            }
        }
    }
}
