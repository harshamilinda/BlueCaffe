using System;
using System.Collections.Generic;

namespace BlueCaffe.Core
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }

        public int Id { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
    public enum OrderStatus {Preparing, Serving, Completed, Cancelled};
}