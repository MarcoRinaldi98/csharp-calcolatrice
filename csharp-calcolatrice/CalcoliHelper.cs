using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        public static int CalcolaSommaNumeri(int num1, int num2) 
        {
            return num1 + num2;
        }

        public static double CalcolaSommaNumeriDouble(double num1, double num2) 
        {  
            return num1 + num2; 
        }

        public static int DifferenzaNumeri(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;
            } else 
            { 
                return num2 - num1;
            }
        }

        public static double DifferenzaNumeriDouble(double num1, double num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;
            }
            else
            {
                return num2 - num1;
            }
        }
    }
}
