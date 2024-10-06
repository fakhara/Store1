namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create instance of ElGiganten, ICA, and XXL
            Store elGiganten = new ElGigenten();
            Store ica = new ICA();
            Store xxl = new XXL();

            //Add the stores to a list of store
            List<Store> stores = new List<Store> { elGiganten, ica, xxl };

            //Loop through the list of stores
            foreach (Store store in stores)
            {
                // Print store's name, opening and closing times
                Console.WriteLine($"Store: {store.Name}");
                Console.WriteLine($"Opening Time: {store.OpeningTime}");
                Console.WriteLine($"Closing Time: {store.ClosingTime}");

                // Call GetProducts and print the products
                List<Product> products = store.GetProducts();
                Console.WriteLine("Products:");
                foreach (Product product in products)
                {
                    Console.WriteLine($"- {product.ProductName}: {product.Price}");
                }
                Console.WriteLine(); // Add a blank line for readability

            }
        }
    }
}