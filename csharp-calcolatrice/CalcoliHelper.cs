using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        // Metodo che calcola la somma di due numeri
        public static int CalcolaSommaNumeri(int num1, int num2) 
        {
            return num1 + num2;
        }
        // Metodo che calcola la somma di due numeri con la virgola
        public static double CalcolaSommaNumeriDouble(double num1, double num2) 
        {  
            return num1 + num2; 
        }
        // Metodo che calcola la differnza tra due numeri
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
        // Metodo che calcola la differnza tra due numeri con la virgola
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
        // Metodo che calcola la moltiplicazione di due numeri
        public static int MoltiplicazioneNumeri(int num1, int num2)
        {
            return num1 * num2;
        }
        // Metodo che calcola la moltiplicazione di due numeri con la virgola
        public static double MoltiplicazioneNumeriDouble(double num1, double num2)
        {
            return num1 * num2;
        }
        // Metodo che calcola il valore assoluto di un numero
        public static int ValoreAssolutoNumero(int num)
        {
            if (num > 0)
            {
                return num;
            } else
            {
                return -num;
            }
        }
        // Metodo che calcola il valore assoluto di un numero con la virgola
        public static double ValoreAssolutoNumeroDouble(double num)
        {
            if (num > 0)
            {
                return num;
            }
            else
            {
                return -num;
            }
        }
        // Metodo che calcola il minimo tra due numeri
        public static int NumeroMinimo(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        // Metodo che calcola il minimo tra due numeri con la virgola
        public static double NumeroMinimoDouble(double num1, double num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        // Metodo che calcola il massimo tra due numeri
        public static int NumeroMassimo(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}
