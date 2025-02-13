using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
        public static void ExecutarAmbMetodeAnonim(Action message) {
            message();
        }
            

        public static void Main()
        {
            ExecutarAmbMetodeAnonim(delegate
            {
                Console.WriteLine("Hola món!");
            });
        }
    }
}