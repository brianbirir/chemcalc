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
    public class Gas
    {
        private const double MOLAR_VOLUME = 22.4;
        private static double gas_Moles;
        private static double gas_Volume;
        private static double gas_RMM = 0;

        public static double gasMolarity(double gasMoles, double gasVolume)
        {
            double gasMolarity;
            gasMolarity = gasMoles / gasVolume;
            return gasMolarity;
        }

        //this method calculates the number of moles of a given gas at standard temperature and pressure
        public static double gasMoles(double gasVolume)
        {

            gas_Moles = gasVolume / MOLAR_VOLUME;
            return gas_Moles;
        }

        //this method calculates the volume of a given gas at standard temperature and pressure
        public static double gasVolume(double gasMoles)
        {
            gas_Volume = gasMoles * MOLAR_VOLUME;
            return gas_Volume;
        }
        //this method calculates the mass of a given gas at standard temperature and pressure
        public static double gasMass(double gasRMM, double gasVolume)
        {
            double gas_Mass;
            gas_Mass = (gasRMM * gasVolume) / MOLAR_VOLUME;
            return gas_Mass;
        }
    }
}
