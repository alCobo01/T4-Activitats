using System;
using System.Collections;
using System.Linq;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            List<int> list = [5, 10, 15, 20, 25];

            list.Add(42);

            list.Insert(0, 7);

            list.Remove(15);

            list = list.OrderByDescending(x => x).ToList();

            MyUtils.DisplayEven(list);
        }
    }
}