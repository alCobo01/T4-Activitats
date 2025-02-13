using System;
using System.Text;

namespace T4Activitats
{
    public class SalesEmployee : Employee
    {
        public float Comssion { get; set; }

        public SalesEmployee(string code, string name, string surname, DateTime birthDate, DateTime hireDate, float monthSalary, int payments, float comssion) : base(code, name, surname, birthDate, hireDate, monthSalary, payments)
        {
            Comssion = comssion;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Comssion: {Comssion}");
            return sb.ToString();
        }
    }
}
