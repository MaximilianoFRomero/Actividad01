using Actividad01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad01.Resources
{
    public static class StaticOrder
    {
        public static Order GetOrderUS() 
        {
            Order order = new Order(null , "Georgia", StaticItems.GeneratedItemList());
            
            return order;
        }

        public static Order GetOrderEU()
        {
            Order order = new Order("Spain", null, StaticItems.GeneratedItemList());

            return order;
        }

        public static Order GetOrderChinese()
        {
            Order order = new Order(null, null, StaticItems.GeneratedItemList());

            return order;
        }
    }
}
