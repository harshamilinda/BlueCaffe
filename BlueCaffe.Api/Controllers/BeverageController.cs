using BlueCafe.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BlueCafe.Api.Controllers
{
    public class BeverageController : ApiController
    {
        private IBeverageRepository Repository;
        public BeverageController(IBeverageRepository repo) => Repository = repo;
        public IEnumerable<Beverage> Get() => Repository.GetAll();
        public void Post(Beverage beverage) => Repository.Add(beverage);
    }
}
