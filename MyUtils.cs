using System;

namespace T4Activitats
{
    public static class MyUtils
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
        public static string ReadString()
        {
            string input;
            while (string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                Console.Write("Please, write a valid string: ");
            }
            return input;
        }
    }
}
