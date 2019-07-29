using System;
using System.Collections.Generic;

namespace northwindApi.NorthwindDBModel
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeTerritory = new HashSet<EmployeeTerritory>();
            InverseReportsToEmployee = new HashSet<Employee>();
            OrderHeader = new HashSet<OrderHeader>();
        }

        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int TitleId { get; set; }
        public int TitleOfCourtesyId { get; set; }
        public int? HobbyId { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateId { get; set; }
        public string ZipCode { get; set; }
        public string PersonalPhone { get; set; }
        public string Extension { get; set; }
        public byte[] Picture { get; set; }
        public string Notes { get; set; }
        public int? ReportsToEmployeeId { get; set; }
        public decimal Salary { get; set; }

        public virtual Hobby Hobby { get; set; }
        public virtual Employee ReportsToEmployee { get; set; }
        public virtual State State { get; set; }
        public virtual Title Title { get; set; }
        public virtual TitleOfCourtesy TitleOfCourtesy { get; set; }
        public virtual ICollection<EmployeeTerritory> EmployeeTerritory { get; set; }
        public virtual ICollection<Employee> InverseReportsToEmployee { get; set; }
        public virtual ICollection<OrderHeader> OrderHeader { get; set; }
    }
}
