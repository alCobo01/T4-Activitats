using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            const string FirstMessage = "How many students do you want to save? ",
                NameMessage = "Write the name of the student {0}: ",
                AgeMessage = "Write the age of the student {0}: ";

            int numberOfValues, age;
            string name;

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            Console.Write(FirstMessage);
            numberOfValues = MyUtils.ReadInt();
            for (int i = 0; i < numberOfValues; i++)
            {
                Console.Write(NameMessage, i + 1);
                name = MyUtils.ReadString();
                Console.Write(AgeMessage, i + 1);
                age = MyUtils.ReadInt();
                dictionary.Add(name, age);
            }

            Console.WriteLine("\nStudents saved:");
            foreach (var item in dictionary)
            {
                Console.WriteLine("Name: {0}, Age: {1}", item.Key, item.Value);
            }
        }
    }
}