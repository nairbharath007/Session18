using ProductApp.Model;
using System.Globalization;
using System.Text;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo cultureInfo = new CultureInfo("hi-IN");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;

            Console.OutputEncoding = Encoding.Default;



            // Simulate an online electronics store

            // Create some products
            Product laptop = new Product(1, "Laptop", 1000, 5);
            Product smartphone = new Product(2, "Smartphone", 500, 10);
            Product headphones = new Product(3, "Headphones", 50, 15);
            Product tablet = new Product(4, "Tablet", 300, 8);

            // Create a customer's shopping cart
            LineItem cartItem1 = new LineItem(1, 2, laptop);           // Adding 2 laptops
            LineItem cartItem2 = new LineItem(2, 3, smartphone);      // Adding 3 smartphones
            LineItem cartItem3 = new LineItem(3, 1, headphones);      // Adding 1 pair of headphones

            // Create another customer's shopping cart
            LineItem cartItem4 = new LineItem(4, 1, laptop);           // Adding 1 laptop
            LineItem cartItem5 = new LineItem(5, 2, tablet);          // Adding 2 tablets

            // Create orders for the customers
            Order customerOrder1 = new Order(1, DateTime.Now, new List<LineItem> { cartItem1, cartItem2, cartItem3 });
            Order customerOrder2 = new Order(2, DateTime.Now, new List<LineItem> { cartItem4, cartItem5 });

            // Create multiple orders for the same customer
            List<Order> customerOrders1 = new List<Order>
            {
                customerOrder1,
                new Order(3, DateTime.Now, new List<LineItem> { cartItem1, cartItem3 }), // Another order for Customer 1
                new Order(4, DateTime.Now, new List<LineItem> { cartItem2, cartItem4 })  // Another order for Customer 1
            };

            // Create customers
            Customer customer1 = new Customer(101, "A Y Raaajuuu", customerOrders1);
            Customer customer2 = new Customer(102, "Casie H O", new List<Order> { customerOrder2 });

            // Display customer information and orders
            Console.WriteLine("Welcome to D-MART!");
            Console.WriteLine("---------------------------------\n");

            Console.WriteLine("Customer 1:");
            Console.WriteLine(customer1.PrintCustomerInfo());

            Console.WriteLine("\nCustomer 2:");
            Console.WriteLine(customer2.PrintCustomerInfo());

        }
    }
}