using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            //Font de dades
            List<int> list = new List<int> { 1, -1, 59, 34, 21, -22};

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
                                          select num;

            //Apartat D




        }
    }
}