using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop.BL
{
    class MenuItem
    {
        public MenuItem(string name, string type, int price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }
        public string name;
        public string type;
        public int price;

        public bool IsDrink()
        {
            if (type == "drink")
            {
                return true;
            }
            return false;
        }
        public bool IsFood()
        {
            if (type == "food")
            {
                return true;
            }
            return false;
        }
        public int GetPrice()
        {
            return price;
        }
    }
}
