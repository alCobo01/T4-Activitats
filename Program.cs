using System;
using System.Collections;
using System.Security.Cryptography;

namespace T4Activitats
{
    public class Program
    {
        public delegate int Operate(int a, int b);
        public static int Multiplicar(int a, int b) => a * b;
        public static int Dividir(int a, int b) => a / b;
        public static void Main()
        {
            Operate multiplicacio = Multiplicar;
            Operate divisio = Dividir;
            int resultatMult = multiplicacio(2, 3);
            int resultatDiv = divisio(6, 2);

            Console.WriteLine(resultatMult);
            Console.WriteLine(resultatDiv);
        }
    }
}