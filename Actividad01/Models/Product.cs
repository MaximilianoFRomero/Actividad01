using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad01.Models
{
    public class Product
    {
        private String productName {  get; set; }

        private double price { get; set; }

        public Product(string productName, double price) 
        {
            this.productName = productName;

            this.price = price;
        }


    }
}
