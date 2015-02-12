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
    public partial class BoylesLaw : PhoneApplicationPage
    {

        public BoylesLaw()
        {
            InitializeComponent();
        }

        //method that calculates new volume using Boyle's Law using the Calculate Volume button
        private void btnCalcPressureTwo_Click(object sender, RoutedEventArgs e)
        {

            if (txtVolumeOne.Text == "" || txtPressureOne.Text == "" || txtVolumeTwo.Text == "")
            {
                MessageBox.Show("Empty Textfield. Insert value", "Input Error", MessageBoxButton.OK);
            }
            else
            {

                decimal volumeOne = decimal.Parse(txtVolumeOne.Text);
                decimal pressureOne = decimal.Parse(txtPressureOne.Text);
                decimal volumeTwo = decimal.Parse(txtVolumeTwo.Text);
                decimal resultNewPressure = decimal.Round(GasLaw.boyleLawPressure(pressureOne, volumeOne, volumeTwo), 3);
                //convert result from decimal type to string type
                string strNewPressure = Convert.ToString(resultNewPressure);//convert to string to display on the message box
                //display the result in a message box
                MessageBoxResult m = MessageBox.Show(strNewPressure + " mmHg", "Result", MessageBoxButton.OK);

                if (m == MessageBoxResult.OK)
                {
                    txtVolumeOne.Text = "";
                    txtPressureOne.Text = "";
                    txtPressureTwo.Text = "";

                }
            }
        }


        //method that calculates new volume using Boyle's Law using the Calculate Volume button
        private void btnCalcVolumeTwo_Click(object sender, RoutedEventArgs e)
        {
            if (txtVolumeOne1.Text == "" || txtPressureOne1.Text == "" || txtPressureTwo.Text == "")
            {
                MessageBox.Show("Empty Textfield. Insert value", "Error", MessageBoxButton.OK);
            }
            else
            {

                decimal volumeOne = decimal.Parse(txtVolumeOne1.Text);
                decimal pressureOne = decimal.Parse(txtPressureOne1.Text);
                decimal pressureTwo = decimal.Parse(txtPressureTwo.Text);

                decimal resultNewVolume = decimal.Round(GasLaw.boyleLawPressure(pressureOne, volumeOne, pressureTwo), 3);
                //convert result from decimal type to string type
                string strNewVolume = Convert.ToString(resultNewVolume);//convert to string to display on the message box
                //display the result in a message box
                MessageBoxResult m = MessageBox.Show(strNewVolume + " dm3", "Result", MessageBoxButton.OK);

                if (m == MessageBoxResult.OK)
                {
                    txtVolumeOne1.Text = "";
                    txtPressureOne1.Text = "";
                    txtVolumeTwo.Text = "";
                }
            }
        }

    }
}