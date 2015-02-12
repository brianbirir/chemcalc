using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace ChemCalc
{
    public partial class GasLaws : PhoneApplicationPage
    {
        public GasLaws()
        {
            InitializeComponent();
        }

        private void btnBoyleslaw_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/BoylesLaw.xaml", UriKind.Relative));
        }

        private void btnCharlesLaw_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CharlesLaw.xaml", UriKind.Relative));
        }

        private void btnGeneralGasLaw_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/GrahamGasLaw.xaml", UriKind.Relative));
        }
    }
}