using System;
using System.Collections.Generic;

namespace T4Activitats
{
    public class EmployeesComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x == null || y == null) return 0;
            if (x == null) return 1;
            if (y == null) return -1;
            return x.GetSeniority().CompareTo(y.GetSeniority());
        }
    }
}
