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
                /*Console.WriteLine($"Store: {store.Name}");
                Console.WriteLine($"Opening Time: {store.OpeningTime}");
                Console.WriteLine($"Closing Time: {store.ClosingTime}");*/

                // Print store's name
                Console.WriteLine($"Store: {store.Name}");

                // Format and print opening and closing times (e.g., "09:00 - 21:00")
                string openingTime = store.OpeningTime.ToString("HH:mm");
                string closingTime = store.ClosingTime.ToString("HH:mm");
                Console.WriteLine($"Opening Hours: {openingTime} - {closingTime}");

                // Call GetProducts and print the products in a user-friendly way
                Console.WriteLine("Products:");
                List<Product> products = store.GetProducts();
                //Console.WriteLine("Products:");
                foreach (Product product in products)
                {
                    Console.WriteLine($"- {product.ProductName}: {product.Price}");
                }
                Console.WriteLine(new string('-', 30)); // Separator for better readability

            }
        }
    }
}