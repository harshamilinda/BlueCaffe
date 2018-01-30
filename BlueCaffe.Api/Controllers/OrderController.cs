using BlueCafe.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BlueCafe.Infrastructure;

namespace BlueCafe.Api.Controllers
{
    public class OrderController : ApiController
    {
        private IOrderRepository Repository;
        public OrderController(IOrderRepository repo)
        {
            this.Repository = repo;
        }
        // GET api/values
        public IEnumerable<Order> Get()
        {
            return Repository.GetAllOrders();
        }
        public void Post(Order order)
        {
            Repository.PlaceOrder(order);
        }
        public void Put(int id, Order order)
        {
            Repository.UpdateOrder(id, order);
        }
    }
}
