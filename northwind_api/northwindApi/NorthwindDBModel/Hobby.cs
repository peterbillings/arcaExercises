using System;
using System.Collections.Generic;

namespace northwindApi.NorthwindDBModel
{
    public partial class Hobby
    {
        public Hobby()
        {
            Employee = new HashSet<Employee>();
        }

        public int HobbyId { get; set; }
        public string HobbyName { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
