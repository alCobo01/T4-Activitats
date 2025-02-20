using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace T4Activitats
{
    public class Program
    {
        public delegate int Operacio(int a, int b);
        public static int ExecutaOperacio(Operacio op, int a, int b) => op(a, b);
        public static int Multiplicar(int a, int b) => a * b;
        public static int Dividir(int a, int b) => a / b;
        public static void Main()
        {
           Operacio multi = Multiplicar;
           Operacio divi = Dividir;
           Console.WriteLine(ExecutaOperacio(multi, 5, 3));
           Console.WriteLine(ExecutaOperacio(divi, 10, 2));
        }
    }
}