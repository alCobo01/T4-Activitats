using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            string[] alumnes =
            [
            "Joan Garcia, 9.5",
            "Anna Lopez, 8.0",
            "Marc Puig, 7.5",
            "Laura Costa, 9.0",
            "Pau Marti, 8.5"
            ];

            string path = Path.GetFullPath(@"..\..\..\files\text.txt");

            File.WriteAllLines(path, alumnes);

            using StreamReader sr = File.OpenText(path);
            string? line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

        }
    }
}