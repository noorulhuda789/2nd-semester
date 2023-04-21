using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week3lab;
namespace week3lab
{
    class Program
    {
        static void Task1()
        {
            Student s1 = new Student();
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.matricmarks);
            Console.WriteLine(s1.fscmarks);
            Console.WriteLine(s1.ecatmarks);
            Console.WriteLine(s1.aggregate);
        }
        static void Task2()
        {
            Student s1 = new Student();
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.matricmarks);
            Console.WriteLine(s1.fscmarks);
            Console.WriteLine(s1.ecatmarks);
            Console.WriteLine(s1.aggregate);
        }
        static void saTask1a()
        {
            Student s1 = new Student();
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.matricmarks);
            Console.WriteLine(s1.fscmarks);
            Console.WriteLine(s1.ecatmarks);
            Console.WriteLine(s1.aggregate);
        }
        static void saTask1b()
        {
            Console.WriteLine("first object");
            Student s1 = new Student();

            Console.WriteLine(s1.name);
            Console.WriteLine(s1.matricmarks);
            Console.WriteLine(s1.fscmarks);
            Console.WriteLine(s1.ecatmarks);
            Console.WriteLine(s1.aggregate);
            Console.WriteLine();
            Console.WriteLine("second object");
            Console.WriteLine();
            Student s2 = new Student();
            Console.WriteLine(s2.name);
            Console.WriteLine(s2.matricmarks);
            Console.WriteLine(s2.fscmarks);
            Console.WriteLine(s2.ecatmarks);
            Console.WriteLine(s2.aggregate);
            Console.WriteLine();
            Console.WriteLine("third object");
            Console.WriteLine();
            Student s3 = new Student();
            Console.WriteLine(s3.name);
            Console.WriteLine(s3.matricmarks);
            Console.WriteLine(s3.fscmarks);
            Console.WriteLine(s3.ecatmarks);
            Console.WriteLine(s3.aggregate);

        }
        static void Task3()
        {
            Student s1 = new Student("jack");
            Student s2 = new Student("jill");
            Console.WriteLine(s1.name);
            Console.WriteLine(s2.name);
        }
        static void Sa2task1b()
        {
            Student s1 = new Student("jack", 10f, 40f, 12f, 7.8f);
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.matricmarks);
            Console.WriteLine(s1.fscmarks);
            Console.WriteLine(s1.ecatmarks);
            Console.WriteLine(s1.aggregate);
            Console.WriteLine();
            Console.WriteLine("second object");
            Console.WriteLine();
            Student s2 = new Student("jill", 5.2f, 14f, 4.5f, 6.7f);
            Console.WriteLine(s2.name);
            Console.WriteLine(s2.matricmarks);
            Console.WriteLine(s2.fscmarks);
            Console.WriteLine(s2.ecatmarks);
            Console.WriteLine(s2.aggregate);
            Console.WriteLine();
            Console.WriteLine("third object");
            Console.WriteLine();
            Student s3 = new Student("noor", 100f, 100f, 1000f, 111f);
            Console.WriteLine(s3.name);
            Console.WriteLine(s3.matricmarks);
            Console.WriteLine(s3.fscmarks);
            Console.WriteLine(s3.ecatmarks);
            Console.WriteLine(s3.aggregate);
        }
        static void Sa2task1a()
        {
            Student s1 = new Student("jack", 10f, 40f, 12f, 7.8f);
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.matricmarks);
            Console.WriteLine(s1.fscmarks);
            Console.WriteLine(s1.ecatmarks);
            Console.WriteLine(s1.aggregate);
        }
        static void Taskfor()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        static void Taskforeach()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
        static void clockType()
        {
            //default constuctor
            clockType time = new clockType();
            Console.WriteLine("empty time :");
            time.printtime();

            //parameterized constructor
            clockType hour = new clockType(7);
            Console.WriteLine("hour time :");
            hour.printtime();
            //two parameter
            clockType min = new clockType(7,8);
            Console.WriteLine("hour time :");
           min.printtime();
            //3 parameter
            clockType sec = new clockType(7,8,10);
            Console.WriteLine("hour time :");
            sec.printtime();
            //increment second 
            sec.incrementsecond();
            Console.WriteLine("full time(increment second):");
            sec.printtime();
            //increment hours 
            sec.incrementhour();
            Console.WriteLine("full time(increment second):");
            sec.printtime();
            // increment minutes 
            sec.incrementminute();
            Console.WriteLine("full time(increment second):");
            sec.printtime();
            //check if equal
            bool flag = sec.isEqual(9, 11, 11);
            Console.WriteLine("flag:" + flag);
            //check if equal with object
            clockType cmp = new clockType(10,12,1);
            flag = sec.isEqual(cmp);
            Console.WriteLine("object flag : " + flag);
        }
        static void challenge1()
        {
            //default constuctor
            clockType time = new clockType();
            Console.WriteLine("empty time :");
            time.printtime();

            //parameterized constructor
            clockType hour = new clockType(7);
            Console.WriteLine("hour time :");
            hour.printtime();
            //two parameter
            clockType min = new clockType(7, 8);
            Console.WriteLine("hour time :");
            min.printtime();
            //3 parameter
            clockType sec = new clockType(7, 8, 10);
            Console.WriteLine("hour time :");
            sec.printtime();
            //increment second 
            sec.incrementsecond();
            Console.WriteLine("full time(increment second):");
            sec.printtime();
            //increment hours 
            sec.incrementhour();
            Console.WriteLine("full time(increment second):");
            sec.printtime();
            // increment minutes 
            sec.incrementminute();
            Console.WriteLine("full time(increment second):");
            sec.printtime();
            //check if equal
            bool flag = sec.isEqual(9, 11, 11);
            Console.WriteLine("flag:" + flag);
            //check if equal with object
            clockType cmp = new clockType(10, 12, 1);
            flag = sec.isEqual(cmp);
            Console.WriteLine("object flag : " + flag);
            int TimeElapse = sec.ElapseTime();
            Console.Write("Elapse Time: ");
            sec.formatter(TimeElapse);
            Console.WriteLine();

            int TimeRemain = sec.RemainingTime();
            Console.Write("Remaining Time: ");
            sec.formatter(TimeRemain);
            Console.WriteLine();

            clockType C = new clockType(8, 15, 11);
            int difference = sec.Difference(C);
            Console.Write("Difference Time: ");
            sec.formatter(difference);
            Console.WriteLine();
        }
        static void product()
        {
            List<Product> item = new List<Product>();
             int choice =menu();
            while (choice != 6)
            {
                if (choice== 1)
                {
                    addproduct(item);
                }
                else if(choice==2)
                {
                    view(item);
                }
                else if (choice == 3)
                {
                    heighestprice(item);
                }
                else if (choice == 4)
                {
                    saletax(item);
                }
                else if(choice==5)
                {
                    toorder(item);
                }
                choice = menu();
            }
        }
        static int menu()
        {
          
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Veiw product");
            Console.WriteLine("3. Highest Price");
            Console.WriteLine("4.  Sale Tax");
            Console.WriteLine("5. product to be ordered");
            Console.WriteLine("6. exist");
            int choice;
            Console.WriteLine("enter choice:");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        static void addproduct(List<Product> item)
        {
            Product s1 = new Product();
            Console.WriteLine("enter product name:");
            s1.name = Console.ReadLine();
            Console.WriteLine("enter  price:");
            s1.price = int.Parse(Console.ReadLine());
            Console.WriteLine("enter  category:");
            s1.category = Console.ReadLine();
            Console.WriteLine("enter  stock quantity:");
            s1.quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("enter  minimum stock quantity:");
            s1.minimum = int.Parse(Console.ReadLine());
            s1.tax = s1.calculator();
            item.Add(s1);
        }
        static void  view(List<Product> item)
        {
            foreach(var i in item)
            {
                Console.WriteLine("name :{0}  price:{1}  category :{2} qauntity:{3}  mininmum: {4}", i.name, i.price, i.category, i.quantity, i.minimum);
            }
        }
        static void heighestprice(List<Product> item)
        {
            string nameis="", iscategory="";
            float price = -1f;
           
            foreach (var i in item)
            {
                if(price<=i.price)
                {
                    price = i.price;
                    nameis = i.name;
                    iscategory = i.category;
                }
            }
            Console.WriteLine("name :" + nameis);
            Console.WriteLine("Category :" + iscategory);
            Console.WriteLine("highest price :" + price  ) ;

        }
        static void saletax(List<Product> item)
        {
            Console.WriteLine("name     Tax");
            foreach (var i in item)
            {
                Console.WriteLine(i.name + "     " + i.tax);
            }
        }
        static void toorder(List<Product> item)
        {
            bool flag = true;
            foreach (var i in item)
            {
               if(i.quantity<10)
                {
                    Console.Write("these items should bi order again");
                    Console.WriteLine(i.name + "  " + i.quantity);
                    flag = false;
                }

            }
            if(flag==true)
            {
                Console.WriteLine("no product is needed to ordered");
            }
        }
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            //saTask1a();
            // saTask1b();
            //Task3();
            // Sa2task1a();
            // Sa2task1b();
            //Taskfor();
            // Taskforeach();
            //clockType();
            challenge1();
            //product();
            Console.ReadKey();
        }
    }
}

