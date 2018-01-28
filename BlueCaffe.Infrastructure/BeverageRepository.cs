using BlueCafe.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueCafe.Infrastructure
{
    public class BeverageRepository : IBeverageRepository
    {
        private CafeContext context;
        public BeverageRepository(CafeContext db)
        {
            context = db;
        }

        public void Add(Beverage beverage)
        {
            context.Beverages.Add(beverage);
            context.SaveChanges();
        }

        public void Delete(Beverage beverage)
        {
            context.Beverages.Remove(beverage);
            context.SaveChanges();
        }

        public Beverage Get(int id)
        {
            return context.Beverages.FirstOrDefault(b => b.BeverageId == id);
        }

        public IEnumerable<Beverage> GetAll()
        {
            return context.Beverages;
        }

        public void Update(Beverage beverage)
        {
            var item = context.Beverages.FirstOrDefault(b => b.BeverageId == context.Entry(beverage).Entity.BeverageId);

            if (item != null)
            {
                context.Entry(item).CurrentValues.SetValues(beverage);
                context.SaveChanges();
            }
           
           
        }
    }
}
