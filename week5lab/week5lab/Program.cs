using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week5lab.multipleclass;
namespace week5lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // SF1();
            // SF2();
            SF3();
            Console.ReadKey();
        }
        static void SF1()
        {
            string name, hometwon;
            int matricmarks,rollnumber;
            bool isdayscholar;
            float cgpa;
            double fsc, ecat;
            Console.Clear();
            Console.WriteLine("Enter name of student");
            name = Console.ReadLine();
            Console.WriteLine("Enter rollnumber of student");
            rollnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fsc marks of student");
            fsc =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter matric marks of student");
            matricmarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ecat marks of student");
            ecat = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter cgpa of student");
            cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter home twon of student");
            hometwon = Console.ReadLine();
            Console.WriteLine("are you dayscholar  (true/false)");
            isdayscholar = bool.Parse(Console.ReadLine());
            Console.WriteLine("have uyou any scholarship  (true/false)");
            bool istakingscholarship = bool.Parse(Console.ReadLine());
            Student s1 = new Student(name, matricmarks, fsc, rollnumber, ecat, cgpa, hometwon, isdayscholar, istakingscholarship);
            double merit=s1.merit();
            bool dayscholar = s1.scholarship(merit);
            Console.WriteLine("merit of student :" + merit);
            if(dayscholar==true)
            {
                Console.WriteLine("student is availing scholarship");
            }
            else
            {
                Console.WriteLine("student is not availing scholarship");
            }
        }
        static void SF2()
        {
            int pagenumber, bookmarks, price;
            string name;
            List<string> chapter = new List<string>();
            Console.Clear();
            Console.WriteLine("Enter name of book");
            name = Console.ReadLine();
            Console.WriteLine("Enter pagenumber of book");
            pagenumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price of book");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter page number which contain bookmark of book");
            bookmarks = int.Parse(Console.ReadLine());
            
            Console.WriteLine("how many chapters you want to add:");
            int num = int.Parse(Console.ReadLine());
            Book s1 = new Book(name, pagenumber, bookmarks, price);
            Book s2 = new Book();
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("chapter name:");
                string chap = Console.ReadLine();
                s2.chapter.Add(chap);

            }
            
            

            int choice = menu();

            checkcondition(choice,s1);

        }
        static int menu()
        {
            Console.WriteLine("1.Book mark");
            Console.WriteLine("2.reset book mark");
            Console.WriteLine("3. price");
            Console.WriteLine("4.new price");
            Console.WriteLine("5.chapter name");
            Console.WriteLine("6.exit");
            Console.WriteLine("enter your choice");
            int choice;
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        static void checkcondition(int i, Book s1)
        {

            do
                if (i >= 1 && i <= 5)
                {
                    if (i == 1)
                    {
                        int bookmark = s1.getbookmark();
                        Console.WriteLine("book marks is availble on this page number:" + bookmark);
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine("on which page number you want to check if bookmark is availble");
                        int num = int.Parse(Console.ReadLine());
                        s1.getbookmark(num);
                    }
                    else if (i == 3)
                    {
                        int price = s1.priceis();

                        Console.WriteLine("price of book is" + price);
                    }
                    else if (i == 4)
                    {
                        Console.WriteLine("New price:");
                        int num = int.Parse(Console.ReadLine());
                        s1.newprice(num);
                    }
                    else
                    {
                        Console.WriteLine("Enter chapter number:");
                        int p = int.Parse(Console.ReadLine());
                        string chap = s1.chapternameis(p);
                        Console.WriteLine("chapter name:" + chap);
                    }
                    i = menu();
                } while (i != 6);
        }
        static void SF3()
        {

        }


    }
}
