using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            List<int> list = [13, 25, 87, 52, 21, 90, 5, 8, 10];
            list.Where(n => n %  2 == 0).ToList().ForEach(n => Console.WriteLine(n));
        }
    }
}