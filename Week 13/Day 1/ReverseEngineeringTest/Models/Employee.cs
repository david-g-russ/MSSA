using System;
using System.Collections.Generic;

#nullable disable

namespace ReverseEngineeringTest
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string EmpFname { get; set; }
        public string EmpLname { get; set; }
        public int DeptId { get; set; }
        public string Designation { get; set; }
        public decimal? Salary { get; set; }

        public virtual Department Dept { get; set; }
    }
}
