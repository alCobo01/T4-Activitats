using System;
using System.Collections;

namespace T4Activitats
{
    public static class MyUtils
    {
        public static int ReadInt()
        {
            const string invalidNumberMessage = "Please, write a valid number: ";

            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write(invalidNumberMessage);
            }
            return number;
        }

        public static string ReadString()
        {
            const string invalidStringMessage = "Please, write a valid string: ";

            string input;
            while (string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                Console.Write(invalidStringMessage);
            }
            return input;
        }

        public static void Display(List<int> list)
        {
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void Display(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void DisplayEven(List<int> list)
        {
            foreach (int item in list)
            {
                if (item % 2 == 0) Console.WriteLine(item);
            }
        }

        public static void FindString(ArrayList list, string str)
        {
            const string stringFoundMessage = "{0} is in the list";
            const string stringNotFoundMessage = "{0} is not in the list";

            if (list.Contains(str))
            {
                Console.WriteLine(stringFoundMessage, str);
            }
            else
            {
                Console.WriteLine(stringNotFoundMessage, str);
            }
        }
    }
}
