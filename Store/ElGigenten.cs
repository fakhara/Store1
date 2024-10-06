using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    //Subclass ElGigantan
     public class ElGigenten :Store
     {
        // Constructor that uses the base class constructor
        public ElGigenten() : base("ElGiganten", new TimeOnly(9, 0), new TimeOnly(20, 0)) { }

        // Override GetProducts method
        public override List<Product> GetProducts()
        {
            return new List<Product>
            {
            new Product("Laptop", 15000m),
            new Product("Smartphone", 8000m),
            new Product("Television", 12000m)
            };
        }
    }
}
