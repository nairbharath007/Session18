using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    internal class Customer
    {
        //CultureInfo cultureInfo = new CultureInfo("hi-IN");
        //System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(int id, string name, List<Order> orders)
        {
            Id = id;
            Name = name;
            Orders = orders;
        }

        public int GetOrderCount()
        {
            return Orders.Count;
        }

        public double GetTotalOrderPrice()
        {
            double totalCost = 0;
            foreach (var order in Orders)
            {
                totalCost += order.CalculateOrderPrice();
            }
            return totalCost;
        }

        public string PrintCustomerInfo()
        {
            string customerInfo = $"Customer Id: {Id}\n";
            customerInfo += $"Customer Name: {Name}\n";
            customerInfo += $"Total orders/order count: {GetOrderCount()}\n\n";

            for (int i = 0; i < Orders.Count; i++)
            {
                Order order = Orders[i];
                customerInfo += $"Order No. {i + 1}\n";
                customerInfo += $"Order Id: {order.Id}\n";
                customerInfo += $"Order Date: {order.Date}\n\n";

                customerInfo += "LineItemId\tProductId\tProductName\tQuantity\tUnitPrice\tDiscount%\tUnitCostAfterDiscount\tTotalLineItemCost\n";
                customerInfo += new string('-', 140) + "\n";

                foreach (var item in order.Items)
                {
                    var product = item.Product;
                    customerInfo += $"{item.Id,-12}\t{product.Id,-12}\t{product.Name,-12}\t" +
                        $"{item.Quantity,-8}\t{product.Price,-12:C2}\t{product.DiscountPercent}%\t\t" +
                        $"{product.CalculateDiscountedPrice():C2}\t\t\t{item.CalculateLineItemCost():C2}\n";
                }
                customerInfo += "\n";

                double orderCost = order.CalculateOrderPrice();
                //customerInfo += $"\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tOrder Cost: {orderCost:F2}\n\n";

                string orderCostLine = $"Order Cost: {orderCost:C2}";
                //int spaceCount = 138 - orderCostLine.Length; 
                customerInfo += new string(' ', 120) + "..................." + "\n\n";

                customerInfo += new string(' ', 120) + orderCostLine + "\n\n";
            }

            return customerInfo;
        }
    }
}


