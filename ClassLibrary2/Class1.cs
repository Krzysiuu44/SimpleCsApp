using System.Collections.Generic;
using System.Data;

namespace ClassLibrary2
{
    public class Class1
    {
        public static double KgToLbs(string x)
        {
            double a = System.Convert.ToDouble(x);
            return a * 2.204622;
        }

        public static double LbsToKg(string x)
        {
            double a = System.Convert.ToDouble(x);
            return a / 2.204622;
        }

        public static double KmToMiles(string x)
        {
            double a = System.Convert.ToDouble(x);
            return a/ 1.609344;
        }
        
        public static double MilesToKm(string x)
        {
            double a = System.Convert.ToDouble(x);
            return a * 1.609344;
        }
        
        public static double FtoC(string x)
        {
            double a = System.Convert.ToDouble(x);
            return (a - 32) / 1.8;
        }
        
        public static double CtoF(string x)
        {
            double a = System.Convert.ToDouble(x);
            return a * 1.8 + 32;
        }
        
        public static double FeetToMeter(string x)
        {
            double a = System.Convert.ToDouble(x);
            return a * 0.3048;
        }
        
        public static double MeterToFeet(string x)
        {
            double a = System.Convert.ToDouble(x);
            return a / 0.3048;
        }
        
        public static double MphToKph(string x)
        {
            double a = System.Convert.ToDouble(x);
            return a / 0.621;
        }
        
        public static double KphToMph(string x)
        {
            double a = System.Convert.ToDouble(x);
            return a * 0.621;
        }

        public static string CheckAm(int a)
        {
            if (a>12)
            {
                return "pm";
            }
            else
            {
                return "am";
            }
        }

        public static int CheckTime(int a)
        {
            if (a>12)
            {
                a = a - 12;
            }

            return a;
        }
    }
}