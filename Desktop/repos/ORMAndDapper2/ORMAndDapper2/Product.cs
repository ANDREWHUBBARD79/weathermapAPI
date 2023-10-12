using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMAndDapper2
{
    internal class Product
    {
        //each column from the products table will be a property
        public int ProductID { get; set; }
        public string Name { get; set; }

        //price categoryID onSale StockLevel

        public double Price { get; set; }

        public int CategoryID { get; set; }
        public int OnSale { get; set; }

        public string StockLevel { get; set; }
    }
}
