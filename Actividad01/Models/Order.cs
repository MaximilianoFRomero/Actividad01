using Actividad01.Resources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad01.Models
{
    public class Order
    {
        private TaxCalculator taxCalculator = new TaxCalculator();

        private List<Item> lineItems;

        private String? country;

        private String? state;

        public Order(String country, String state, List<Item> lineItems) {

            this.country = country;

            this.state = state;

            this.lineItems = lineItems;
            
        }
        public double getOrderTotal()
        {
            double total = 0;
            foreach (Item item in lineItems) 
            {
                total += GetSubTotal(item) * taxCalculator.getTaxRate(country,state,item.product);
            }
            return total;
        }

        private double GetSubTotal(Item item)
        {
           return item.price * item.quantity;
        }
    }
}
