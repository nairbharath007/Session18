using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    internal class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public List<LineItem> Items { get; set; }

        public Order(int orderId, DateTime date, List<LineItem> items)
        {
            OrderId = orderId;
            Date = date;
            Items = items;
        }

        public double CalculateOrderPrice()
        {
            double totalCost = 0;
            foreach (var item in Items)
            {
                totalCost += item.CalculateLineItemCost();
            }
            return totalCost;
        }
    }
}
