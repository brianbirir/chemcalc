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
    public partial class GasMoleConcept : PhoneApplicationPage
    {
        public GasMoleConcept()
        {
            InitializeComponent();
            SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;
        }

        private void btnGasMoles_Click(object sender, RoutedEventArgs e)
        {
            if (txtGasVolumeMoles.Text == "")
            {
                MessageBox.Show("Empty Textfield. Insert value", "Input Error", MessageBoxButton.OK);
            }
            else
            {
                double gasVolume = double.Parse(txtGasVolumeMoles.Text);

                double resultMoles = Math.Round(Gas.gasMoles(gasVolume), 5);

                string strMoles = Convert.ToString(resultMoles);//convert to string to display on the message box

                MessageBoxResult m = MessageBox.Show(strMoles + " moles", "Result", MessageBoxButton.OK);
                if (m == MessageBoxResult.OK)
                {
                    txtGasVolumeMoles.Text = "";
                }
            }
        }

        private void btnGasVolume_Click(object sender, RoutedEventArgs e)
        {
            if (txtGasMoles.Text == "")
            {
                MessageBox.Show("Empty Textfield. Insert value", "Error", MessageBoxButton.OK);
            }
            else
            {
                double gasMoles = double.Parse(txtGasMoles.Text);

                double resultVolume = Math.Round(Gas.gasVolume(gasMoles), 5);

                string strVolume = Convert.ToString(resultVolume);//convert to string to display on the message box

                MessageBoxResult m = MessageBox.Show(strVolume + " dm3", "Result", MessageBoxButton.OK);
                if (m == MessageBoxResult.OK)
                {
                    txtGasMoles.Text = "";
                }
            }
        }

        private void btnGasMass_Click(object sender, RoutedEventArgs e)
        {
            if (txtGasVolume.Text == "" || txtGasRMM.Text == "")
            {
                MessageBox.Show("Empty Textfield. Insert value", "Error", MessageBoxButton.OK);
            }
            else
            {
                double gasRMM = double.Parse(txtGasRMM.Text);
                double gasVolume = double.Parse(txtGasVolume.Text);
                double resultMass = Math.Round(Gas.gasMass(gasRMM, gasVolume), 5);

                string strMass = Convert.ToString(resultMass);//convert to string to display on the message box

                MessageBoxResult m = MessageBox.Show(strMass + " grams", "Result", MessageBoxButton.OK);
                if (m == MessageBoxResult.OK)
                {
                    txtGasRMM.Text = "";
                    txtGasVolume.Text = "";
                }
            }
        }
    }
 }