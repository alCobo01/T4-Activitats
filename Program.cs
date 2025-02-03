using System;
using System.Collections;
using System.Globalization;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Introdueix la data en format dd/MM/yyyy (exemple: 25/12/2023):");
            string input = MyUtils.ReadString();

            DateTime dataObjectiu;
            //Hem de pasar-li informació sobre la cultura (god knows que significa ??)
            bool dataValida = DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataObjectiu);

            if (dataValida)
            {
                DateTime avui = DateTime.Today;
                int diesRestants = (dataObjectiu >= avui) ? (dataObjectiu - avui).Days : 0;
                Console.WriteLine($"Queden {diesRestants} dies fins a la data indicada.");
            }
            else
            {
                Console.WriteLine("Error: Format de data incorrecte. Utilitza el format dd/MM/yyyy.");
            }
        }
    }
}