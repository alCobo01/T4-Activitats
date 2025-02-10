using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
        public delegate void Notificacio(string missatge);
        public static void MostrarMissatgeConsola(string missatge)
        {
            Console.WriteLine("Missatge: " + missatge);
        }

        public static void MostrarMissatgeAmbEstreles(string missatge)
        {
            Console.WriteLine("********** " + missatge + " **********");
        }

        public static void Main()
        {
            Notificacio notificacio = MostrarMissatgeConsola;
            // += agrega un nou mètode al delegat
            notificacio += MostrarMissatgeAmbEstreles;
            notificacio("Hola món!");
        }
    }
}