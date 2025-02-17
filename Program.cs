using System;
using System.Globalization;
using CsvHelper;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            string path = Path.GetFullPath(@"..\..\..\files\students.csv");

            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<Student>();
            foreach (var student in records)
            {
                Console.WriteLine($"Nom: {student.Nom}, Edat: {student.Edat}, Ciutat: {student.Ciutat}");
            }

        }
    }
}