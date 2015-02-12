using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ChemCalc
{
    public class Molarity
    {
        private static decimal soluteMass;
        private static decimal soluteMoles;
        private static decimal solutionMolarity;
        private static decimal solutionVolume;
        private static decimal soluteRMM;
            //constructor
            Molarity(){

            }

            Molarity(decimal sMass, decimal sRMM, decimal sVol)
            {
               soluteMass = sMass;
               soluteRMM = sRMM;
               solutionVolume = sVol;
            }
   
            //method one for doing volumetric analysis i.e. getting the concentration of a solution
            public static decimal SolutionConcentration(decimal soluteMass, decimal soluteRMM, decimal solutionVolume)
            {
                soluteMoles = soluteMass/soluteRMM;//calculate number of moles in the solution
                solutionMolarity = (soluteMoles*1)/solutionVolume;//calculate molarity of the solution
                return solutionMolarity;
            }

           //method two for doing volumetric analysis i.e. getting the concentration of a solution
            public static decimal SolutionConcentration1(decimal soluteMass, decimal soluteRMM, decimal solutionVolume)
            {
                solutionMolarity = ((soluteMass*1000)/solutionVolume)/soluteRMM;
                return solutionMolarity;
            }
    }
}
