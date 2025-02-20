using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
        public delegate void Operacio(int a, int b); 

        public static void Main()
        {
            Operacio metodeAnonim = delegate (int a, int b)
            {
                Console.WriteLine(Math.Pow(a, b));
            };

            metodeAnonim(2, 3);
        }
    }
}