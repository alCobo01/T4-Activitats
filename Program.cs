using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
        public delegate double Operacio(int a, int b); 

        public static void Main()
        {
            Operacio op = (a, b) => Math.Pow(a, b);
            Console.WriteLine(op(2, 3));
        }
    }
}