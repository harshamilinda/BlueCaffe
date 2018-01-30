using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueCafe.Core
{
    public interface IOrderRepository
    {
        void PlaceOrder(Order order);
        void UpdateOrder(int id,Order order);

        IEnumerable<Order> GetAllOrders();
        IEnumerable<Order> GetOrders(OrderStatus orderStatus);

        Order GetOrder(int id);

    }
}   
