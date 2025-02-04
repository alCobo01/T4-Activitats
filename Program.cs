using System;
using System.Collections;

namespace T4Activitats
{
    public class Program
    {
        public static void Main()
        {
            ArrayList arrList = ["Maria", "Joan", "Anna", 42, true];
            MyUtils.Display(arrList);

            arrList.Remove(42);
            arrList.Remove(true);

            MyUtils.Display(arrList);

            arrList.Insert(2, "Pere");

            MyUtils.FindString(arrList, "Anna");

            //Si sabem que el contingut del arrList es tot string, es pot convertir amb ToArray()
            //Si no, l'hauriem de fer amb Cast<string>().ToArray()
            string[] arr = (string[])arrList.ToArray(typeof(string));

            /* 
            - arrayList.ToArray(typeof(string))
               - ToArray() és un mètode de ArrayList que retorna un Array amb els elements del ArrayList.
               - El paràmetre typeof(string) li indica que l'array resultant ha de ser de tipus string[].
               - Retorna un objecte de tipus Array, però encara no és un string[].

            - (string[]) (Casting)
                - ToArray(typeof(string)) retorna un objecte de tipus Array, que és una classe base de tots els arrays en C#.
                - Com sabem que tots els elements del ArrayList són string, fem un casting explícit a string[] perquè el compilador ho tracti correctament.
             */
        }
    }
}