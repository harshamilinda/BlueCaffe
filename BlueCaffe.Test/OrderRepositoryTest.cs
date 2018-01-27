using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueCafe.Infrastructure;

namespace BlueCafe.Test
{
    [TestClass]
    public class OrderRepositoryTest 
    {
        OrderRepository Repo;

        [TestInitialize]
        public void DBSetup()
        {
            CafeContentInitializer CafeInit = new CafeContentInitializer();
            System.Data.Entity.Database.SetInitializer(CafeInit);

            Repo = new OrderRepository();

        }
    }
}
