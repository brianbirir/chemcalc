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
    public partial class MolaritySoln : PhoneApplicationPage
    {
        public MolaritySoln()
        {
            InitializeComponent();
        }

        private void btnCalcMolarity_Click(object sender, RoutedEventArgs e)
        {
            if (txtSolnMass.Text == "" || txtSolnVolume.Text == "" || txtSolnRMM.Text == "")
            {
                MessageBox.Show("Empty Textfield. Insert value", "Error", MessageBoxButton.OK);
            }
            else
            {
                //instantiate variables
                decimal solnMass = decimal.Parse(txtSolnMass.Text);
                decimal solnVolume = decimal.Parse(txtSolnVolume.Text);
                decimal solnRMM = decimal.Parse(txtSolnRMM.Text);

                //pass values to the molarity method in the static Molarity class
                decimal resultMolarity = decimal.Round(Molarity.SolutionConcentration(solnMass, solnRMM, solnVolume), 2);
                string strResultMolarity = Convert.ToString(resultMolarity);
                MessageBoxResult m = MessageBox.Show(strResultMolarity + " Molar", "Result", MessageBoxButton.OK);

                if (m == MessageBoxResult.OK)
                {
                    txtSolnMass.Text = "";
                    txtSolnVolume.Text = "";
                    txtSolnRMM.Text = "";

                }
            }
        }
    }
}