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
    public partial class CharlesLaw : PhoneApplicationPage
    {
        public CharlesLaw()
        {
            InitializeComponent();
        }

        private void btnCalcTemperatureTwo_Click(object sender, RoutedEventArgs e)
        {
            if (txtVolumeOne.Text == "" || txtTemperatureOne.Text == "" || txtVolumeTwo.Text == "")
            {
                MessageBox.Show("Empty Textfield. Insert value", "Error", MessageBoxButton.OK);
            }
            else
            {
                decimal volumeOne = decimal.Parse(txtVolumeOne.Text);
                decimal temperatureOne = decimal.Parse(txtTemperatureOne.Text);
                decimal volumeTwo = decimal.Parse(txtVolumeTwo.Text);

                decimal resultNewTemp = decimal.Round(GasLaw.charlesLawTemp(temperatureOne, volumeOne, volumeTwo), 2);
                //convert result from decimal type to string type
                string strNewTemp = Convert.ToString(resultNewTemp);//convert to string to display on the message box
                //display the result in a message box
                MessageBoxResult m = MessageBox.Show(strNewTemp + " kelvin", "Result", MessageBoxButton.OK);

                if (m == MessageBoxResult.OK)
                {
                    txtVolumeOne.Text = "";
                    txtTemperatureOne.Text = "";
                    txtVolumeTwo.Text = "";

                }
            }
        }

        private void btnCalcVolumeTwo_Click(object sender, RoutedEventArgs e)
        {
            if (txtVolumeOne1.Text == "" || txtTemperatureOne1.Text == "" || txtTemperatureTwo.Text == "")
            {
                MessageBox.Show("Empty Textfield. Insert value", "Error", MessageBoxButton.OK);
            }

            else
            {

                decimal volumeOne = decimal.Parse(txtVolumeOne1.Text);
                decimal temperatureOne = decimal.Parse(txtTemperatureOne1.Text);
                decimal temperatureTwo = decimal.Parse(txtTemperatureTwo.Text);

                decimal resultNewVol = decimal.Round(GasLaw.charlesLawVol(volumeOne, temperatureOne, temperatureTwo), 2);
                //convert result from decimal type to string type
                string strNewVol = Convert.ToString(resultNewVol);//convert to string to display on the message box
                //display the result in a message box
                MessageBoxResult m = MessageBox.Show(strNewVol + " dm3", "Result", MessageBoxButton.OK);

                if (m == MessageBoxResult.OK)
                {
                    txtVolumeOne1.Text = "";
                    txtTemperatureOne1.Text = "";
                    txtTemperatureTwo.Text = "";

                }
            }
        }

        
    }
}