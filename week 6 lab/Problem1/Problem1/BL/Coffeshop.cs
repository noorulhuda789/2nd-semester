using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.BL
{
    public class CoffeeShop
    {
        public string Name;
        public List<MenuItem> menu;
        public List<string> orders;

        public CoffeeShop(string Name)
        {
            this.Name = Name;
            menu = new List<MenuItem>();
            orders = new List<string>();
        }

        public void AddMenuItem(MenuItem item)
        {
            menu.Add(item);
        }

        public void AddOrder(String item)
        {
            orders.Add(item);
        }

        public string FulfillOrder()
        {
            string ord = null;

            if (orders.Count > 0)
            {
                ord = orders[0];

                orders.Remove(ord);
            }

            return ord;
        }

        public List<string> ListOrders()
        {
            if (orders.Count > 0)
            {
                return orders;
            }
            return null;
        }

        public float DueAmount()
        {
            float price = 0;

            foreach (var x in orders)
            {
                foreach (var y in menu)
                {
                    if (x == y.Name)
                    {
                        price += y.Price;
                    }
                }
            }

            return price;
        }

        public MenuItem CheapestItem()
        {
            List<MenuItem> ascendingMenu = menu.OrderBy(o => o.Price).ToList();
            return ascendingMenu[0];
        }

        public List<MenuItem> DrinksOnly()
        {
            List<MenuItem> drinks = new List<MenuItem>();
            foreach (var x in menu)
            {
                if (x.Type == "Drinks")
                {
                    drinks.Add(x);
                }
            }
            return drinks;
        }

        public List<MenuItem> FoodOnly()
        {
            List<MenuItem> food = new List<MenuItem>();
            foreach (var x in menu)
            {
                if (x.Type == "Food")
                {
                    food.Add(x);
                }
            }
            return food;
        }

    }
}
