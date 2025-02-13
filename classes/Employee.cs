using System;
using System.Text;

namespace T4Activitats
{
    public class Employee
    {
        private static int _count = 0;
        public int Count { get; private set; }
        public float MonthSalary { get; set; }
        public int Payments { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        
        public Employee(string code, string name, string surname, DateTime birthDate, DateTime hireDate, float monthSalary, int payments)
        {
            Count = ++_count;
            Code = code;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            HireDate = hireDate;
            MonthSalary = monthSalary;
            Payments = payments;
            Count = _count;
        }

        public string GetFullName() => $"{Name} {Surname}";
        public string GetReverseName() => $"{Name}, {Surname}";

        public int GetAge()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now < BirthDate.AddYears(age))
                age--;
            return age;
        }

        public int GetSeniority()
        {
            int seniority = DateTime.Now.Year - HireDate.Year;
            if (DateTime.Now < HireDate.AddYears(seniority))
                seniority--;
            return seniority;
        }

        public float GetAnnualSalary() => MonthSalary * Payments;
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("EMPLOYEE");
            sb.AppendLine("------------------------------");
            sb.AppendLine($"Code:        {Code}");
            sb.AppendLine($"Name:        {Name}");
            sb.AppendLine($"Surname:     {Surname}");
            sb.AppendLine($"FullName:    {GetFullName()}");
            sb.AppendLine($"ReverseName: {GetReverseName()}");
            sb.AppendLine($"BirthDate:   {BirthDate.ToShortDateString()}");
            sb.AppendLine($"HireDate:    {HireDate.ToShortDateString()}");
            sb.AppendLine($"MonthSalary: {MonthSalary}");
            sb.AppendLine($"Payments:    {Payments}");
            sb.AppendLine($"Age:         {GetAge()}");
            sb.AppendLine($"Seniority:   {GetSeniority()}");
            sb.AppendLine($"AnnualSalary:{GetAnnualSalary()}");
            return sb.ToString();
        }



    }
}
