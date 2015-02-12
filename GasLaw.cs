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
    public class GasLaw
    {
        private static decimal gasPressure1;
        private static decimal gasPressure2;
        private static decimal gasVolume1;
        private static decimal gasVolume2;
        private static decimal gasTemperature1;
        private static decimal gasTemperature2;

        GasLaw()
        {

        }

        GasLaw(decimal p1, decimal p2, decimal v1, decimal v2, decimal t1, decimal t2)
        {
            gasPressure1 = p1;
            gasPressure2 = p2;
            gasVolume1 = v1;
            gasVolume2 = v2;
            gasTemperature1 = t1;
            gasTemperature2 = t2;
        }

        //calculate new pressure using Boyle's Law
        public static decimal boyleLawPressure(decimal gasPressure1, decimal gasVolume1, decimal gasVolume2)
        {
            gasPressure2 = (gasPressure1 * gasVolume1) / gasVolume2;
            return gasPressure2;
        }

        //calculate new volume using Boyle's Law
        public static decimal boyleLawVolume(decimal gasPressure1, decimal gasVolume1, decimal gasPressure2)
        {
            gasVolume2 = (gasPressure1 * gasVolume1) / gasPressure2;
            return gasVolume2;
        }
        //this method returns the new temperature value
        public static decimal charlesLawTemp(decimal gasTemperature1, decimal gasVolume1, decimal gasVolume2)
        {
            gasTemperature2 = (gasTemperature1 * gasVolume2) / gasVolume1;
            return gasTemperature2;
        }
        //this method returns the new volume value
        public static decimal charlesLawVol(decimal gasVolume1, decimal gasTemperature1, decimal gasTemperature2)
        {
            gasVolume2 = (gasVolume1 * gasTemperature2) / gasTemperature1;
            return gasVolume2;
        }

        public static decimal generalGasLaw1(decimal gasPressure1, decimal gasVolume1, decimal gasTemperature1, decimal gasTemperature2, decimal gasPressure2)
        {
            gasVolume2 = (gasPressure1 * gasVolume1 * gasTemperature2) / (gasTemperature1 * gasPressure2);
            return gasVolume2;
        }
        public static decimal generalGasLaw2(decimal gasPressure1, decimal gasVolume1, decimal gasTemperature1, decimal gasTemperature2, decimal gasVolume2)
        {
            gasPressure2 = (gasPressure1 * gasVolume1 * gasTemperature2) / (gasTemperature1 * gasVolume2);
            return gasPressure2;
        }
        public static decimal generalGasLaw3(decimal gasTemperature1, decimal gasPressure1, decimal gasVolume1, decimal gasPressure2, decimal gasVolume2)
        {
            gasTemperature2 = (gasTemperature1 * gasPressure2 * gasVolume2) / (gasPressure1 * gasVolume1);
            return gasTemperature2;
        }
    }
}
