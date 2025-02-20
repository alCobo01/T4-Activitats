using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
        public delegate void Notificacio(string missatge);
        public static void ExecutarAmbMetodeAnonim(Notificacio message) {
            message("Bona tarda");
        }
            
        public static void Main()
        {
            ExecutarAmbMetodeAnonim(delegate (string missatge)
            {
                Console.WriteLine(missatge);
            });
        }
    }
}