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
            }
            else
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
            }
            else
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
        // Metodo che calcola il massimo tra due numeri con la virgola
        public static double NumeroMassimoDouble(double num1, double num2)
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

        // BONUS
        //Metodo per l’elevamento a potenza che prende come parametri due numeri interi (base ed esponente) e ritorna la base elevata all’esponente con gestione numeri passati = 0
        public static double ElevaAPotenza(int baseNumero, int esponente)
        {
            if (baseNumero == 0)
            {
                if (esponente == 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (esponente == 0)
            {
                return 1;
            }
            else
            {
                return Math.Pow(baseNumero, esponente); // Restituisce il numero specificato (baseNumero) elevato alla potenza specificata (esponente).
            }
        }

        // SUPERBONUS
        // Prova generics di C# con somma di due numeri di tipo dinamico
        public static T SommaNumeri<T>(T numero1, T numero2)
        {
            dynamic num1 = numero1;
            dynamic num2 = numero2;
            return num1 + num2;
        }
    }
}
