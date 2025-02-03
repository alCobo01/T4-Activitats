using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            const string FirstMessage = "How many numbers do you want to save? ",
                 ValueMessage = "Write the number {0} of {1}: ";

            int numberOfValues;

            List<int> values = new List<int>();
            List<int> evenValues = new List<int>();

            Console.Write(FirstMessage);
            numberOfValues = MyUtils.ReadInt();

            for (int i = 0; i < numberOfValues; i++)
            {
                Console.Write(ValueMessage, i + 1, numberOfValues);
                values.Add(MyUtils.ReadInt());
            }

            foreach (int value in values)
            {
                if (value % 2 == 0)
                {
                    evenValues.Add(value);
                }
            }

            MyUtils.Display(evenValues);
        }
    }
}