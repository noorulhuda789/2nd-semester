using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.UI
{
    public class CoffeeUI
    {
        public static void Valid()
        {
            Console.WriteLine("");
            Console.WriteLine("Enter Valid Option");
        }

        public static void Halt()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static int Menu(string name)
        {
            Console.Clear();

            Console.WriteLine("Welcome to " + name + " Coffee's Shop");
            Console.WriteLine(" ");
            Console.WriteLine("1. Add a Menu item");
            Console.WriteLine("2. View the Cheapest item");
            Console.WriteLine("3. View the Drink's Menu");
            Console.WriteLine("4. View the Food's Menu");
            Console.WriteLine("5. Add Order");
            Console.WriteLine("6. Fulfill the order");
            Console.WriteLine("7. View the Orders's List");
            Console.WriteLine("8. Total payable Amount");
            Console.WriteLine("9. Exit");
            Console.WriteLine("");
            Console.WriteLine("Select Option : ");
            return int.Parse(Console.ReadLine());
        }
    }
}
