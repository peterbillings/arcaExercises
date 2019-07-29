using System;
using System.Collections.Generic;

namespace northwindApi.NorthwindDBModel
{
    public partial class State
    {
        public State()
        {
            Customer = new HashSet<Customer>();
            Employee = new HashSet<Employee>();
            OrderHeader = new HashSet<OrderHeader>();
            Supplier = new HashSet<Supplier>();
        }

        public string StateId { get; set; }
        public string StateName { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<OrderHeader> OrderHeader { get; set; }
        public virtual ICollection<Supplier> Supplier { get; set; }
    }
}
