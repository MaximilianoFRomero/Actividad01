using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad01.Models
{
    public class Item
    {
        public Product product { get; set; }

        public double price { get; set; }

        public int quantity { get; set; }

        public Item(Product product, double price, int quantity)
        {
            this.product = product;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
