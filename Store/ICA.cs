using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    //Subclass ICA
    public class ICA :Store
    {
        // Constructor that uses the base class constructor
        public ICA() : base("Ica", new TimeOnly(7, 0), new TimeOnly(22, 0)) { }

        // Override GetProducts method
        public override List<Product> GetProducts()
        {
            return new List<Product>
            {
            new Product("Milk", 15.99m),
            new Product("Bread", 20.50m),
            new Product("Eggs", 30m)
            };
        }
    }
}
