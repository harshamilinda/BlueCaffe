using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueCafe.Core;

namespace BlueCafe.Infrastructure
{
    public class CafeContentInitializer : DropCreateDatabaseIfModelChanges<CafeContext>
    {
        protected override void Seed(CafeContext context)
        {
            var beverage = new List<Beverage>
            {
                new Beverage(){Name="Late",UnitPrice=1.50},
                new Beverage(){Name="Cappuccino",UnitPrice=2},
                new Beverage(){Name="expresso",UnitPrice=1}
            };
            beverage.ForEach(b => context.Beverages.Add(b));
            context.SaveChanges();

           

            base.Seed(context);
           
        }
    }

}
