using BlueCaffe.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueCaffe.Infrastructure
{
    public class CafeContext : DbContext
    {
        public CafeContext() : base("name=CafeContext")
        {

        }
        public DbSet<Beverage> Beverages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order> OrderDetails { get; set; }
    }
}
