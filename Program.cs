using System;
using System.Collections;
using System.Text;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            //Font de dades
            List<int> list = new List<int> { 1, -1, 59, 34, 21, -22};
            const string str = "La vida es una tombola";

            //Apartat A
            var evenQuery = from num in list
                            where (num % 2) == 0
                            select num;

            //Apartat B
            var positiveQuery = from num in list
                                where num > 0
                                select num;

            //Apartat C
            var greatherThanTwentyQuery = from num in list
                                          where num > 20
                                          select Math.Pow(num, 2);

            //Apartat D
            var frequencyQuery = from num in list
                                 group num by num into numGroup
                                 select new { numGroup.Key, Count = numGroup.Count() };

            /*foreach (var item in frecuencyQuery)
            {
                Console.WriteLine($"El número {item.Key} es repeteix {item.Count} vegades");
            }*/

            //Apartat E
            var stringFrecuencyQuery = from c in str
                                       group c by c into charGroup
                                       select new { charGroup.Key, Count = charGroup.Count() };

            /*foreach (var item in stringFrecuencyQuery)
            {
                Console.WriteLine($"La lletra {item.Key} es repeteix {item.Count} vegades");
            }*/

            //Apartat F
            




        }
    }
}