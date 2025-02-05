using System;
using System.Collections;
using System.Globalization;
using System.Linq;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            const string IsPosteriorMessage = "La primera data és posterior a la segona",
                IsNotPosteriorMessage = "La primera data no és posterior a la segona";

            bool isPosterior;
            DateTime[] dates = new DateTime[2];

            for (int i = 0; i < 2; i++)
            {
                dates[i] = DateUtils.GetValidDate();
            }

            isPosterior = DateUtils.IsPosterior(dates[0], dates[1]);

            Console.WriteLine(isPosterior ? IsPosteriorMessage : IsNotPosteriorMessage);
        }

        
    }
}