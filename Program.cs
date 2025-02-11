using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            Func<int, int, int> multiplicacio = (a, b) => a * b;
            int result = ExecuteOperation(multiplicacio, 3, 4);
            Console.WriteLine(result);

            Action<int, int> printSum = (a, b) => Console.WriteLine($"Sum: {a + b}");
            ExecuteAction(printSum, 3, 4);
        }

        public static int ExecuteOperation(Func<int, int, int> operation, int x, int y)
        {
            return operation(x, y);
        }

        public static void ExecuteAction(Action<int, int> action, int x, int y)
        {
            action(x, y);
        }
    }
}