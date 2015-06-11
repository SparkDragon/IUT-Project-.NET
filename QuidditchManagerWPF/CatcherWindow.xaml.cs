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
    public partial class CatcherWindow : Window
    {
        public CatcherWindow()
        {
            InitializeComponent();
        }
    }

    public class Catchers : ObservableCollection<string>
    {
        public Catchers()
        {
            PlayerBusiness playerManager = new PlayerBusiness();
            IEnumerable<string> listCatcher = playerManager.GetCatchers();
            foreach (string catcher in listCatcher)
            {
                Add(catcher);
            }
        }
    }
}
