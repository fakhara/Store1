using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    //Subclass XXL
    public class XXL : Store
    {
        // Constructor that uses the base class constructor
        public XXL() : base("XXL", new TimeOnly(10, 0), new TimeOnly(21, 0)) { }

        // Override GetProducts method
        public override List<Product> GetProducts()
        {
            return new List<Product>
            {
            new Product("Running Shoes", 1200m),
            new Product("Tennis Racket", 800m),
            new Product("Bicycle", 7000m)
            };
        }
    }
}
