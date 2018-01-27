using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueCaffe.Core;

namespace BlueCaffe.Infrastructure
{
    public class OrderRepository : IOrderRepository
    {
        CafeContext context = new CafeContext();
        public IEnumerable<Order> GetAllOrders()
        {
            return context.Orders;
        }

        public Order GetOrder(int id)
        {
            return context.Orders.FirstOrDefault(o => o.Id == id);
        }

        public IEnumerable<Order> GetOrders(OrderStatus orderStatus)
        {
            return context.Orders.Where(o=>o.Status == orderStatus);
        }

        public void PlaceOrder(Order order)
        {
            order.Status = OrderStatus.Preparing;
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public void PrepareOrder(Order order)
        {
            context.Entry(order).Entity.Status = OrderStatus.Serving;
            context.SaveChanges();
        }

        public void ServeOrder(Order order)
        {
            context.Entry(order).Entity.Status = OrderStatus.Completed;
            context.SaveChanges();
        }
    }
}
