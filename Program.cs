using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
           Dictionary<string, float> employees = new Dictionary<string, float>() 
           {
               {"John", 1000},
               {"Mary", 2000},
               {"Steve", 3000},
               {"Anna", 4000},
               {"Peter", 5000}
           };

            foreach (KeyValuePair<string, float> employee in employees)
            {
                Console.WriteLine("Employee: {0}, Salary: {1}", employee.Key, employee.Value);
            }
        }
    }
}