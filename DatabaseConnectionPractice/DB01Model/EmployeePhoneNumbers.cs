using System;
using System.Collections.Generic;

namespace DatabaseConnectionPractice.DB01Model
{
    public partial class EmployeePhoneNumbers
    {
        public int EmployeeId { get; set; }
        public int PhoneNumberId { get; set; }

        public virtual Employees Employee { get; set; }
        public virtual PhoneNumbers PhoneNumber { get; set; }
    }
}
