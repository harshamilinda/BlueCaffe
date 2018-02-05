using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueCafe.Infrastructure;
using BlueCafe.Core;

namespace BlueCafe.Test
{
    [TestClass]
    public class OrderRepositoryTest 
    {
        
        CafeContext context = new CafeContext();
        [TestInitialize]
        public void DBSetup()
        {
            CafeContentInitializer CafeInit = new CafeContentInitializer();
            System.Data.Entity.Database.SetInitializer(CafeInit);

            
            Assert.IsNotNull(new OrderRepository(context));

        }
        [TestMethod]
        public void GetAllBeverage_ShouldReturnAllBeverage()
        {
            var testBeverage = GetTestBeverage();
            var controller = new BeverageRepository(context);

            var result = controller.GetAll() as List<Beverage>;
            Assert.AreEqual(testBeverage.Count, result.Count);
        }
        [TestMethod]
        public void GetProduct_ShouldReturnCorrectProduct()
        {
            var testBeverage = GetTestBeverage();
            var controller = new BeverageRepository(context);

            var result = controller.Get(1) as Beverage;
            Assert.IsNotNull(result);
            Assert.AreEqual(testBeverage[0].Name, result.Name);
        }

        private List<Beverage> GetTestBeverage()
        {
            var testBeverage = new List<Beverage>
            {
                new Beverage(){Name="Late",UnitPrice=1.50},
                new Beverage(){Name="Cappuccino",UnitPrice=2},
                new Beverage(){Name="expresso",UnitPrice=1}
            };

            return testBeverage;
        }
    }

}
