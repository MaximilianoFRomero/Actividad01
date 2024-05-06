using Actividad01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad01.Resources
{
    public static class StaticItems
    {
        public static List<Item> GeneratedItemList() 
        {
            List<Product> products = StaticProduct.GenetatedProductList();
            List<Item> generatedItemList = new List<Item>();
            generatedItemList.Add(new Item(products[0], 10, 1));
            generatedItemList.Add(new Item(products[1], 10, 1));
            generatedItemList.Add(new Item(products[2], 10, 1));
            return generatedItemList; 
        }
    }
}
