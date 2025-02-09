using System;
using System.Collections;
using System.Collections.Generic;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            const int MAX = 3;

            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            list.RemoveAll(n => n > MAX);

            foreach (int n in list)
            {
                Console.WriteLine(n);
            }
        }
    }
}