using System;
using System.Collections.Generic;

namespace northwindApi.NorthwindDBModel
{
    public partial class Shipper
    {
        public Shipper()
        {
            OrderHeader = new HashSet<OrderHeader>();
        }

        public int ShipperId { get; set; }
        public string ShipperName { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<OrderHeader> OrderHeader { get; set; }
    }
}
