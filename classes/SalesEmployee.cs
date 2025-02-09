using System;

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
            return $@"
            Sales Employee
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
