using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            const string Message = "La suma de tots els valors a la llista es {0}";

            List<int> list = [1, 2, 3, 4, 5];
            Console.WriteLine(Message, list.Sum());


        }
    }
}