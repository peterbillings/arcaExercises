using System;
using System.Collections.Generic;

namespace northwindApi.NorthwindDBModel
{
    public partial class OrderHeader
    {
        public OrderHeader()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int OrderHeaderId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int ShipperId { get; set; }
        public DateTime OrderDateTime { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime? ShippedDateTime { get; set; }
        public decimal Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipStateId { get; set; }
        public string ShipZipCode { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual State ShipState { get; set; }
        public virtual Shipper Shipper { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
