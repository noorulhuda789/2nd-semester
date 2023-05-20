using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6.UI
{
    class MenuUI
    {
        public static string menu()
        {
            Console.Clear();
            Console.WriteLine("1.add student");
            Console.WriteLine("2. Add degree");
            Console.WriteLine("3.calculate merit");
            Console.WriteLine("4. Veiw registerd students");
            Console.WriteLine("5. veiw  register for specific program");
            Console.WriteLine("6. Register subject for specific student");
            Console.WriteLine("7. Calculate fee for all Registered students");
            Console.WriteLine("8. Exit");
            string  num = Console.ReadLine();
            return num;

        }
        public void header()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*                                *");
            Console.WriteLine("*           UAMS                  *");
            Console.WriteLine("*                                *");
            Console.WriteLine("*********************************");
        }
        public static void clearScreen()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
