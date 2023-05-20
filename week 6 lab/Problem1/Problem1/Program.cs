using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_01.BL;
using Problem_01.UI;
using Problem1.UI;

namespace Problem_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            string name = ItemUI.GetName();
            CoffeeShop shop = new CoffeeShop(name);

            do
            {
                option = CoffeeUI.Menu(name);

                if (option == 1)
                {
                    shop.AddMenuItem(ItemUI.TakeItemInput());
                }

                else if (option == 2)
                {
                    ItemUI.CheapItem(shop.CheapestItem());
                }

                else if (option == 3)
                {
                    ItemUI.SpecialMenu(shop.DrinksOnly());
                }

                else if (option == 4)
                {
                    ItemUI.SpecialMenu(shop.FoodOnly());
                }

                else if (option == 5)
                {
                    shop.AddOrder(ItemUI.GetName());
                }

                else if (option == 6)
                {
                    ItemUI.Fulfill(shop.FulfillOrder());
                }

                else if (option == 7)
                {
                    ItemUI.OrdersMenu(shop.orders);
                }

                else if (option == 8)
                {
                    ItemUI.Amount(shop.DueAmount());
                }

                else
                {
                    CoffeeUI.Valid();
                }

                CoffeeUI.Halt();
            }
            while (option != 9);
        }
    }
}
