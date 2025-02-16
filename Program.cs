using System;
using System.Globalization;
using CsvHelper;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            using var reader = new StreamReader("students.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<Student>();
            foreach (var student in records)
            {
                Console.WriteLine($"Nom: {student.Nom}, Edat: {student.Edat}, Ciutat: {student.Ciutat}");
            }

        }
    }
}