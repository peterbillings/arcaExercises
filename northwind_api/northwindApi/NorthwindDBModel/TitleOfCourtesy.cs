using System;
using System.Collections.Generic;

namespace northwindApi.NorthwindDBModel
{
    public partial class TitleOfCourtesy
    {
        public TitleOfCourtesy()
        {
            Employee = new HashSet<Employee>();
        }

        public int TitleOfCourtesyId { get; set; }
        public string TitleOfCourtesyName { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
