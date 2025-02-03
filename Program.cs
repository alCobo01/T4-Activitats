using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            const string FirstMessage = "How many values do you want to write: ",
                SecondMessage = "Write value {0} of {1}: ";

            int numberOfValues;

            ArrayList array = new ArrayList();
            Console.Write(FirstMessage);
            numberOfValues = MyUtils.ReadInt();

            for (int i = 0; i < numberOfValues; i++)
            {
                Console.Write(SecondMessage, i + 1, numberOfValues);
                array.Add(Console.ReadLine());
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}