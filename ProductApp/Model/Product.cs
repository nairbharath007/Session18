using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    internal class Product
    {
        

        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPercent { get; set; }

        public Product(int productId, string name, double price, double discountPercent)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            DiscountPercent = discountPercent;
        }

        public double CalculateDiscountedPrice()
        {
            return (Price - (Price * (DiscountPercent / 100)));
        }
    }
}
