using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueCafe.Core;

namespace BlueCafe.Infrastructure
{
    public class OrderRepository : IOrderRepository
    {

        private CafeContext context;
        public OrderRepository(CafeContext db)
        {
            context = db;
        }
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

      
   
        public void UpdateOrder(int id, Order order)
        {
            var item = context.Orders.FirstOrDefault(o => o.Id == id);
            item = order;
            context.SaveChanges();
        }
    }
}
