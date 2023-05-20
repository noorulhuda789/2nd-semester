using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_01.UI;
using Problem_01.BL;

namespace Problem_01.UI
{
    public class ItemUI
    {
        public static string GetName()
        {
            Console.Write("Enter the name : ");
            return Console.ReadLine();
        }

        public static MenuItem TakeItemInput()
        {
            string name = GetName();

            Console.Write("Enter the type : ");
            string type = Console.ReadLine();

            Console.Write("Enter the Price : ");
            float price = float.Parse(Console.ReadLine());

            MenuItem item = new MenuItem(name, type, price);

            return item;
        }

        public static void CheapItem(MenuItem item)
        {
            Console.WriteLine("Name".PadRight(20, ' ') + "Price");
            Console.WriteLine(" ");
            Console.WriteLine(item.Name.PadRight(20, ' ') + item.Price);
        }

        public static void SpecialMenu(List<MenuItem> menu)
        {
            if (menu.Count > 0)
            {
                Console.WriteLine("Name".PadRight(20, ' ') + "Price");

                foreach (var x in menu)
                {
                    Console.WriteLine(x.Name.PadRight(20, ' ') + x.Price);
                }
            }
            else
            {
                Console.WriteLine("No Item of this type available !");
            }
        }

        public static void OrdersMenu(List<string> menu)
        {
            if (menu.Count > 0)
            {
                Console.WriteLine("Name");

                foreach (var x in menu)
                {
                    Console.WriteLine(x);
                }
            }
            else
            {
                Console.WriteLine("No order received !");
            }
        }

        public static void Fulfill(string name)
        {
            Console.WriteLine("");
            Console.WriteLine("This " + name + " is ready");
        }

        public static void Amount(float price)
        {
            Console.WriteLine("");
            Console.WriteLine("Total price is :  " + price);
        }

    }
}
