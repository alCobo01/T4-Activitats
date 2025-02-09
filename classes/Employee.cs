using System;

namespace T4Activitats
{
    public class Employee
    {
        private static int _count = 0;
        public int Count { get; private set; }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public float MonthSalary { get; set; }
        public int Payments { get; set; }

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

        public string FullName() => $"{Name} {Surname}";
        public string ReverseName() => $"{Name}, {Surname}";

        public int GetAge()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now < BirthDate.AddYears(age))
                age--;
            return age;
        }

        public int Seniority()
        {
            int seniority = DateTime.Now.Year - HireDate.Year;
            if (DateTime.Now < HireDate.AddYears(seniority))
                seniority--;
            return seniority;
        }

        public float AnnualSalary() => MonthSalary * Payments;
        public override string ToString()
        {
            return $@"
            EMPLOYEE
            ------------------------------
            Code:        {Code}
            Name:        {Name}
            Surname:     {Surname}
            BirthDate:   {BirthDate.ToShortDateString()}
            HireDate:    {HireDate.ToShortDateString()}
            MonthSalary: {MonthSalary}
            Payments:    {Payments}
            Age:         {GetAge()}
            Seniority:   {Seniority()}
            AnnualSalary:{AnnualSalary()}
            ";
        }



    }
}
