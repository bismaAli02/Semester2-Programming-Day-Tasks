using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_Shop.BL;

namespace Coffee_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeShop TCS = new CoffeeShop("Tesha\'s Coffee Shop");
            while (true)
            {
                char option = Menu();
                if (option == '1')
                {
                    MenuItem item = AddMenuItem();
                    TCS.AddMenuItem(item);
                }
                else if (option == '2')
                {
                    CheapestItem(TCS);
                }
                else if (option == '3')
                {
                    ViewDrinkMenu(TCS);
                }
                else if (option == '4')
                {
                    ViewFoodMenu(TCS);
                }
                else if (option == '5')
                {
                    AddOrder(TCS);
                }
                else if (option == '6')
                {
                    FulFillOrder(TCS);
                }
                else if (option == '7')
                {
                    OrdersList(TCS);
                }
                else if (option == '8')
                {
                    AmountToBePaid(TCS);
                }
                else if (option == '9')
                {
                    break;
                }
                else
                {

                }
                Console.WriteLine("Enter any key to Continue");
                Console.ReadKey();
                Console.Clear();

            }
        }
        static char Menu()
        {
            Console.WriteLine("Press 1 to Add Menu Item");//
            Console.WriteLine("Press 2 to View the Cheapest Item in the menu");//
            Console.WriteLine("Press 3 to View the Drink’s Menu");//
            Console.WriteLine("Press 4 to View the Food’s Menu");//
            Console.WriteLine("Press 5 to Add Order");//
            Console.WriteLine("Press 6 to Fulfill Order");//
            Console.WriteLine("Press 7 to View the Order's List");
            Console.WriteLine("Press 8 to View Total Payable Amount");//
            Console.WriteLine("Press 9 to EXIT");
            char op = char.Parse(Console.ReadLine());
            return op;
        }
        static MenuItem AddMenuItem()
        {
            string name, type;
            int price;
            Console.Write("Enter the Name of Item: ");
            name = Console.ReadLine();
            Console.Write("Enter the Type of Item: ");
            type = Console.ReadLine();
            Console.Write("Enter the Price of Item: ");
            price = int.Parse(Console.ReadLine());
            MenuItem item = new MenuItem(name, type, price);
            return item;
        }
        static void CheapestItem(CoffeeShop TCS)
        {
            Console.WriteLine("The Cheapest Item in The Menu is: " + TCS.CheapestItem());
        }
        static void ViewDrinkMenu(CoffeeShop TCS)
        {
            foreach (var item in TCS.menu)
            {
                if (item.IsDrink())
                {
                    Console.WriteLine(item.name + "\t\t" + item.GetPrice());
                }
            }
        }
        static void ViewFoodMenu(CoffeeShop TCS)
        {
            foreach (var item in TCS.menu)
            {
                if (item.IsFood())
                {
                    Console.WriteLine(item.name + "\t\t" + item.GetPrice());
                }
            }
        }
        static void AddOrder(CoffeeShop Shop)
        {
            string orderName;
            Console.Write("Enter the name of the MenuItem You want to order: ");
            orderName = Console.ReadLine();
            if (Shop.AddOrder(orderName))
            {
                Console.WriteLine("Order Added!");
            }
            else
            {
                Console.WriteLine("This item is currently unavailable!");
            }
        }
        static void AmountToBePaid(CoffeeShop TCS)
        {
            Console.WriteLine("The Amount to be paid is: " + TCS.DueAmount());
        }
        static void FulFillOrder(CoffeeShop TCS)
        {
            if (TCS.FulFillOrders())
            {
                foreach (var item in TCS.orders)
                {
                    Console.WriteLine("The " + item + " is ready");
                }

                TCS.ClearOrdersList();
            }
            else
            {
                Console.WriteLine("All Orders have been FulFilled");
            }
        }
        static void OrdersList(CoffeeShop TCS)
        {
            List<string> orders = TCS.ListOrders();
            foreach (var order in orders)
            {
                Console.WriteLine("Order name: " + order);
            }
        }
    }
}
