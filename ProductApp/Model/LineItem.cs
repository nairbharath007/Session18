using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    internal class LineItem
    {
        public int LineItemId { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public LineItem(int lineItemId, int quantity, Product product)
        {
            LineItemId = lineItemId;
            Quantity = quantity;
            Product = product;
        }

        public double CalculateLineItemCost()
        {
            return (Product.CalculateDiscountedPrice() * Quantity);
        }
    }
}
