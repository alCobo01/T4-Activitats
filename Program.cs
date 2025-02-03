using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            const string FirstMessage = "How many students do you want to save? ",
                 NameMessage = "Write the name {0} of {1}: ",
                 AgeMessage = "Write the age of the student {0}: ";

            int numberOfValues;
            string name;

            List<string> names = new List<string>();

            Console.Write(FirstMessage);
            numberOfValues = MyUtils.ReadInt();

            for (int i = 0; i < numberOfValues; i++)
            {
                Console.Write(NameMessage, i + 1, numberOfValues);
                name = MyUtils.ReadString();
                names.Add(name);
            }

            //Cal implementar l'interficie IComparable quan utilitzem classes creades per nosaltres
            List<string> sortedNames = new List<string>(names);
            sortedNames.Sort();

            Console.WriteLine("The names in order are:");
            MyUtils.Display(sortedNames);
            Console.WriteLine("The names in reverse order are:");
            MyUtils.Display(names);


        }
    }
}