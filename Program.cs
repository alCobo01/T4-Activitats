using System;
using System.Collections;
using System.Linq;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            const string StudentMessage = "\n Please, write the name of the student: ";

            Dictionary<string, int> students = new Dictionary<string, int>();

            students.Add("Marc", 21);
            students.Add("Laura", 19);
            students.Add("Pau", 22);

            MyUtils.Display(students);

            Console.Write(StudentMessage);
            string student = MyUtils.ReadString();
            if (students.ContainsKey(student))
            {
                //Accedeix al valor de la key de la variable "student"
                Console.WriteLine($"{student} is {students[student]} years old");
            }
            Console.WriteLine();

            students.Remove("Laura");

            MyUtils.Display(students);
        }
    }
}