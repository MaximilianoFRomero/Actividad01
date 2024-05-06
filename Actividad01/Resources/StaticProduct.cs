using Actividad01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad01.Resources
{
    public static class StaticProduct
    {
        public static List<Product> GenetatedProductList()
        {
            var productList = new List<Product>();
            productList.Add(new Product("Papas", 10));
            productList.Add(new Product("Arroz", 10));
            productList.Add(new Product("Queso", 10));

            return productList;
        }
    }
}
