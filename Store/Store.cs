using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Store
    {
        // Properties
        public string Name { get; set; }
        public TimeOnly OpeningTime { get; set; }
        public TimeOnly ClosingTime { get; set; }

        // Constructor
        public Store(string name, TimeOnly openingTime, TimeOnly closingTime)
        {
            Name = name;
            OpeningTime = openingTime;
            ClosingTime = closingTime;
        }

        // Virtual method GetProducts, to be overridden by subclasses

        public virtual List<Product> GetProducts()
        {
            // Either return an empty list or throw an exception to indicate it must be overridden
            throw new NotImplementedException("GetProducts method should be overridden in derived classes.");
        }
    }
}
