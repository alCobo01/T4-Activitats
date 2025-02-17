using System;
using System.Collections;
using System.Text.Json;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            const string Message = "Fitxer creat correctament! Es pot consultar a {0}";

            string path = Path.GetFullPath(@"..\..\..\files\llibres.json");
            System.IO.Directory.CreateDirectory(@"..\..\..\files\");

            List<Llibre> llistaLlibres = new List<Llibre>
            {
                new Llibre{Any=1999, Autor= "J.K. Rowling", Titol="Harry Potter"},
                new Llibre{Any=2003, Autor= "Dan Brown", Titol="El Codigo Da Vinci"},
                new Llibre{Any=2010, Autor= "Suzanne Collins", Titol="Los juegos del hambre"},
                new Llibre{Any=2012, Autor= "E.L. James", Titol="50 sombras de Grey"}
            };

            string jsonString = JsonSerializer.Serialize(llistaLlibres);
            File.WriteAllText(path, jsonString);

            Console.WriteLine(Message, path);
        }
    }
}