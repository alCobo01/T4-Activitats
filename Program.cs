using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace T4Activitats
{
    public class Program
    {
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^(?:\+34\s?)?(\d{9}|\d{3}\s?\d{3}\s?\d{3})$");
        }

        public static void Main()
        {
            Console.WriteLine(IsValidPhoneNumber("+34 600 123 456"));
            Console.WriteLine(IsValidPhoneNumber("60012345"));
        }
    }
}