using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
           
        public static void Main()
        {
            Func<int, int, int> suma = (x, y) => x + y;
            Console.WriteLine(suma(2, 3));
        }
    }
}