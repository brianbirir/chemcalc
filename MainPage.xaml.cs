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
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;
        }

        private void btnGases_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/GasMoleConcept.xaml", UriKind.Relative));
        }

        private void btnGasLaws_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/GasLaws.xaml", UriKind.Relative));
        }

        private void btnMolarity_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MolaritySoln.xaml", UriKind.Relative));
        }

        private void btnLabNoteBook_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/LabNoteBook.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

        private void AppbarEdit_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Help.xaml", UriKind.Relative));
        }

        private void AppBarrFav_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/ChemInfo.xaml", UriKind.Relative));
        }

    }
}