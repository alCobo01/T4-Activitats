using System;
using System.Collections;
using System.Globalization;
using System.Linq;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            List<Employee> employees =
            [
                new Employee("E001", "John", "Doe", new DateTime(1980, 1, 1), new DateTime(2010, 1, 1), 1000, 12),
                new Employee("E002", "Jane", "Doe", new DateTime(1985, 1, 1), new DateTime(2015, 1, 1), 1200, 12),
                new Employee("E003", "Alice", "Doe", new DateTime(1990, 1, 1), new DateTime(2020, 1, 1), 1500, 12),
                new Employee("E004", "Bob", "Doe", new DateTime(1995, 1, 1), new DateTime(2021, 1, 1), 2000, 12),
                new Employee("E005", "Eve", "Doe", new DateTime(2000, 1, 1), new DateTime(2022, 1, 1), 2500, 12)
            ];

            List<SalesEmployee> salesEmployees = 
            [
                new SalesEmployee("S001", "Mariluz", "De la Tumba", new DateTime(1980, 1, 1), new DateTime(2010, 1, 1), 1000, 12, 0.1f),
                new SalesEmployee("S002", "Maebecita", "Roquetas", new DateTime(1985, 1, 1), new DateTime(2015, 1, 1), 1200, 12, 0.1f),
                new SalesEmployee("S003", "Estela", "Reynolds", new DateTime(1990, 1, 1), new DateTime(2020, 1, 1), 1500, 12, 0.1f),
                new SalesEmployee("S004", "Ruth", "Pequeñaja", new DateTime(1995, 1, 1), new DateTime(2021, 1, 1), 2000, 12, 0.1f),
                new SalesEmployee("S005", "Paca", "Pacheco", new DateTime(2000, 1, 1), new DateTime(2022, 1, 1), 2500, 12, 0.1f)
            ];


            // La paraula clau delegate s'utilitza per definir un mètode anònim que pren un objecte Employee com a paràmetre
            // i imprimeix els seus detalls a la consola. Aquest mètode anònim es passa al mètode ForEach per ser executat
            // per a cada element de la llista employees.
            employees.ForEach(delegate (Employee employee)
            {
                Console.WriteLine(employee);
            });

            Console.WriteLine(employees[3].GetAge());






        }

        
    }
}