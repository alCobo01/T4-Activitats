using System;

namespace T4Activitats
{
    public class MyUtils
    {
        public static int ReadInt()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Please, write a valid number: ");
            }
            return number;
        }
    }
}