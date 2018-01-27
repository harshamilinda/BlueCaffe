using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueCaffe.Core
{
    public interface IOrderRepository
    {
        void PlaceOrder(Order order);
        void PrepareOrder(Order order);
        void ServeOrder(Order order);

        IEnumerable<Order> GetAllOrders();
        IEnumerable<Order> GetOrders(string orderStatus);

        Order GetOrder(int id);

    }
}   
