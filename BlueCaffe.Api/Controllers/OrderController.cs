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
        private IOrderRepository repository;
        public OrderController(IOrderRepository repo)
        {
            this.repository = repo;
        }
        // GET api/values
        public IEnumerable<Order> Get()
        {
            return repository.GetAllOrders();
        }
       
    }
}
