using System;
using System.Collections.Generic;

namespace northwindApi.NorthwindDBModel
{
    public partial class Customer
    {
        public Customer()
        {
            OrderHeader = new HashSet<OrderHeader>();
        }

        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateId { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public decimal? AnnualRevenue { get; set; }

        public virtual State State { get; set; }
        public virtual ICollection<OrderHeader> OrderHeader { get; set; }
    }
}
