using System;
using System.Collections.Generic;

namespace northwindApi.NorthwindDBModel
{
    public partial class Supplier
    {
        public Supplier()
        {
            Product = new HashSet<Product>();
        }

        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateId { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string HomePage { get; set; }

        public virtual State State { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
