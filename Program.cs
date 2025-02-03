using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            Parella<string, int> parella1 = new Parella<string, int>("Hola", 3);
            Parella<double, bool> parella2 = new Parella<double, bool>(3.14, true);

            Console.WriteLine(parella1);
            Console.WriteLine(parella2);
        }
    }
}