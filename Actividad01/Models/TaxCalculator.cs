using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad01.Models
{
    public class TaxCalculator
    {
        public double getTaxRate(string country, string state, Product product) 
        {
            double taxRate = 0;

            if (state != null)
            {
                taxRate = GetUSTax(state);
            }
            else
                if (country != null)
            {
                taxRate = GetEUTax(country);
            }
            else
                if (product != null)
            {
                taxRate = GetChineseTax(product);
            }

            return taxRate;
        }

        private double GetUSTax( string state ) { return 10; }

        private double GetEUTax( string country ) { return 20; }

        private double GetChineseTax( Product product ) { return 30; }
    }
}
