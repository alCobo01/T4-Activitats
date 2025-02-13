using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace T4Activitats
{
    public class Program
    {
        public static bool IsValidEmail(string email)
        {
            //explicació regex: https://chatgpt.com/share/67addd07-ead4-800d-9185-b1d6786daccb
            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
        public static void Main()
        {
            Console.WriteLine(IsValidEmail("usuari@gmail.com"));
            Console.WriteLine(IsValidEmail("usuari@gmail"));
        }
    }
}