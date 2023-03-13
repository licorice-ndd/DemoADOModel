using System;
using System.Collections.Generic;

namespace PE_SU22_Q2.Models;

public partial class OrderDetail
{
    public Product()
    {
        OrderDetails = new HashSet<OrderDetail>();
    }
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public short Quantity { get; set; }

    public float Discount { get; set; }
    public virtual Order Order { get; set; }
    public virtual Product Product { get; set; }
    public virtual Category Category { get; set; }
    public virtual ICollection<OrderDetail> OrderDetails { get; set; }
}
