using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            string[] arrayStrings = ["hola", "adeu", "bon dia", "bona nit"];
            List<string> listStrings = arrayStrings.ToList();

            //MAL suspenso -_-
            //foreach (string item in listStrings) { Console.WriteLine(item); }

            listStrings.ForEach(item => Console.WriteLine(item));
        }
    }
}