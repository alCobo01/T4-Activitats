using System;
using System.Globalization;

namespace T4Activitats
{
    public class DateUtils
    {
        public static DateTime GetValidDate()
        {
            const string DatePromptMessage = "Introdueix una data en format dd/MM/yyyy (exemple: 25/12/2023): ";
            const string InvalidDateMessage = "Data no vàlida. Torna-ho a intentar.";

            DateTime dataObjectiu = DateTime.MinValue;
            bool dataValida = false;

            while (!dataValida)
            {
                Console.Write(DatePromptMessage);
                string input = MyUtils.ReadString();

                //Hem de pasar-li informació sobre la cultura (god knows que significa ??)
                dataValida = DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataObjectiu);

                if (!dataValida)
                {
                    Console.Write(InvalidDateMessage);
                }
            }

            return dataObjectiu;
        }

        public static bool IsPosterior(DateTime dateOne, DateTime dateTwo)
        {
            return dateOne < dateTwo;
        }
    }
}
