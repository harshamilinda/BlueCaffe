using BlueCafe.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueCafe.Core
{
    public interface IOrderDetailsRepository
    {
        void Add(IEnumerable<OrderDetail> orderDetails);
        void Delete(IEnumerable<OrderDetail> orderDetails);
    }
}
