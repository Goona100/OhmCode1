using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ohm.Models.Interface;

namespace Ohm.Models.Repository
{
    public class OhmValueCalculator: IOhmValueCalculator
    {
        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            int intReturn = 0;

            int bandAValue = GetColorCodeValue(bandAColor, 0);
            int bandBValue = GetColorCodeValue(bandBColor, 0);
            int bandCValue = GetColorCodeValue(bandCColor, 0);
            int bandDValue = GetColorCodeValue(bandDColor, 0);

            string significantValue = string.Empty;
            significantValue = bandAValue.ToString() + bandBValue.ToString();

            double finalValue = Convert.ToInt64(significantValue) * Math.Pow(10, bandCValue);

            intReturn = Convert.ToInt32(finalValue);


            return intReturn;
        }


        public int  GetColorCodeValue(string ClrName, int BandValue)
        {
            int rtnValue = 0;
            switch (ClrName)
            {
                case "Black":
                    rtnValue = 0;
                    break;
                case "Brown":
                    rtnValue = 1;
                    break;
                case "Red":
                    rtnValue = 2;
                    break;
                case "Orange":
                    rtnValue = 3;
                    break;
                case "Yellow":
                    rtnValue = 4;
                    break;
                case "Green":
                    rtnValue = 5;
                    break;
                case "Blue":
                    rtnValue = 6;
                    break;
                case "Violet":
                    rtnValue = 7;
                    break;
                case "Gray":
                    rtnValue = 8;
                    break;
                case "White":
                    rtnValue = 9;
                    break;

                   
               
            }

            return rtnValue;
        }



    }
}