using System;
using System.Collections.Generic;

namespace northwindApi.NorthwindDBModel
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderHeaderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }

        public virtual OrderHeader OrderHeader { get; set; }
        public virtual Product Product { get; set; }
    }
}
