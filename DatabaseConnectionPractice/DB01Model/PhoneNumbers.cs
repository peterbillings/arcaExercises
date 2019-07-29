using System;
using System.Collections.Generic;

namespace DatabaseConnectionPractice.DB01Model
{
    public partial class PhoneNumbers
    {
        public PhoneNumbers()
        {
            EmployeePhoneNumbers = new HashSet<EmployeePhoneNumbers>();
        }

        public int PhoneNumberId { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberType { get; set; }

        public virtual ICollection<EmployeePhoneNumbers> EmployeePhoneNumbers { get; set; }
    }
}
