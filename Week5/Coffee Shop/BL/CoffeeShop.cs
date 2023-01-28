using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop.BL
{
    class CoffeeShop
    {
        public CoffeeShop(string name)
        {
            this.name = name;
            menu = new List<MenuItem>();
            orders = new List<string>();
        }
        public string name;
        public List<MenuItem> menu;
        public List<string> orders;

        public void AddMenuItem(MenuItem item)
        {
            menu.Add(item);
        }
        public MenuItem IsOrderAvailable(string orderName)
        {
            foreach (var item in menu)
            {
                if (item.name == orderName)
                {
                    return item;
                }
            }
            return null;
        }
        public bool AddOrder(string orderName)
        {
            if (IsOrderAvailable(orderName) != null)
            {
                orders.Add(orderName);
                return true;
            }
            return false;
        }
        public string CheapestItem()
        {
            List<MenuItem> sortedMenu = menu.OrderBy(o => o.price).ToList();
            return sortedMenu[0].name;
        }
        public double DueAmount()
        {
            double TotalPrice = 0;
            MenuItem item;
            foreach (var orderName in orders)
            {
                item = IsOrderAvailable(orderName);
                if (item != null)
                {
                    TotalPrice += item.GetPrice();
                }
            }
            return TotalPrice;
        }
        public void ClearOrdersList()
        {
            orders.Clear();
        }
        public bool IsOrdersListEmpty()
        {
            if (orders.Count > 0)
            {
                return false;
            }
            return true;
        }
        public bool FulFillOrders()
        {
            if (!IsOrdersListEmpty())
            {
                //ClearOrdersList();
                //return "The Item is Ready";
                return true;
            }
            //return "All Orders have been FulFilled";
            return false;
        }
        public List<string> ListOrders()
        {
            if (!IsOrdersListEmpty())
            {
                return orders;
            }
            return null;
        }

    }
}