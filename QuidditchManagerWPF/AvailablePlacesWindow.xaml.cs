﻿using System;
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
using BusinessLayer;

namespace QuidditchManagerWPF
{
    /// <summary>
    /// Logique d'interaction pour AvailablePlacesWindow.xaml
    /// </summary>
    public partial class AvailablePlacesWindow : Window
    {
        public AvailablePlacesWindow(int selectedIndex)
        {
            InitializeComponent();
            MatchManager matchManager = new MatchManager();
            string placeNumber = matchManager.GetAvailablePlaces(selectedIndex);
            string text = placeNumber + " place(s) available";
            places.Content = text;
        }
    }
}
