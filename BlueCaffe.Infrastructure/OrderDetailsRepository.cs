
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueCafe.Core;

namespace BlueCafe.Infrastructure
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {

        private CafeContext context;
        public OrderDetailsRepository(CafeContext db)
        {
            context = db;
        }
        public void Add(IEnumerable<OrderDetail> orderDetails)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<OrderDetail> orderDetails)
        {
            throw new NotImplementedException();
        }
    }
}
