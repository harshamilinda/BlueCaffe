using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueCafe.Core;

namespace BlueCafe.Infrastructure
{
    public class CafeContentInitializer : DropCreateDatabaseAlways<CafeContext>
    {
        protected override void Seed(CafeContext context)
        {
            var beverages = new List<Beverage>
            {
                new Beverage(){Name="Late",UnitPrice=1.50},
                new Beverage(){Name="Cappuccino",UnitPrice=2},
                new Beverage(){Name="expresso",UnitPrice=1}
            };
            beverages.ForEach(b => context.Beverages.Add(b));
            context.SaveChanges();

            var order = new Order() { OrderDate = DateTime.Today.Date, Status = OrderStatus.Preparing };
            var orderDetails = new List<OrderDetail>
            {
                new OrderDetail(){ Beverage=beverages[0],Order=order,Quantity=2},
                new OrderDetail(){ Beverage=beverages[1],Order=order,Quantity=1},
            };
            context.Orders.Add(order);
            orderDetails.ForEach(d => context.OrderDetails.Add(d));
            context.SaveChanges();

            base.Seed(context);

        }
    }

}
