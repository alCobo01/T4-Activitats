using System;
using System.Collections;
using System.Xml.Linq;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            const string Message = "Fitxer creat correctament! Es pot consultar a {0}";

            string path = Path.GetFullPath(@"..\..\..\files\Llibres.xml");
            System.IO.Directory.CreateDirectory(@"..\..\..\files\");

            List<Llibre> llistaLlibres = new List<Llibre>
            {
                new Llibre{Any=1999, Autor= "J.K. Rowling", Titol="Harry Potter"},
                new Llibre{Any=2003, Autor= "Dan Brown", Titol="El Codigo Da Vinci"},
                new Llibre{Any=2010, Autor= "Suzanne Collins", Titol="Los juegos del hambre"},
                new Llibre{Any=2012, Autor= "E.L. James", Titol="50 sombras de Grey"}
            };

            XElement llibres = new XElement("Llibres",
                from llibre in llistaLlibres
                select new XElement("Llibre",
                    new XElement("Any", llibre.Any),
                    new XElement("Titol", llibre.Titol),
                    new XElement("Autor", llibre.Autor)
                )
            );

            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                llibres
            );

            Console.WriteLine(Message, path);
            doc.Save(path);
        }
    }
}