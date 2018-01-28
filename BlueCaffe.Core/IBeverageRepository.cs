using BlueCafe.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueCafe.Core
{
    public interface IBeverageRepository
    {
        void Add(Beverage beverage);
        void Update(Beverage beverage);
        void Delete(Beverage beverage);

        IEnumerable<Beverage> GetAll();
        IEnumerable<Beverage> Get(int id);
        

    }
}
