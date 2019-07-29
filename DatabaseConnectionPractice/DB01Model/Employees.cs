using System;
using System.Collections.Generic;

namespace DatabaseConnectionPractice.DB01Model
{
    public partial class Employees
    {
        public Employees()
        {
            EmployeePhoneNumbers = new HashSet<EmployeePhoneNumbers>();
            Nicknames = new HashSet<Nicknames>();
        }

        public int EmpId { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public decimal? EmpSalary { get; set; }
        public int DeptId { get; set; }

        public virtual Departments Dept { get; set; }
        public virtual ICollection<EmployeePhoneNumbers> EmployeePhoneNumbers { get; set; }
        public virtual ICollection<Nicknames> Nicknames { get; set; }
    }
}
