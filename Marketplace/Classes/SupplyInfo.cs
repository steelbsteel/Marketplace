using Marketplace.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Classes
{
    public class SupplyInfo
    {
        public SupplyInfo(Supply _supply, Product _product) 
        {
            supply = _supply;
            product = _product;
        }
        public Supply supply { get; set; }
        public Product product { get; set; }

    }
}
