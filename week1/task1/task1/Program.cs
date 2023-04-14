using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace task1
{
    class Program
    {
        //static float Calculate(int age, float price)
        //{
        //    float money1 = 0, toy = 0, total, inc = 10;
        //    for (int i = 1; i <= age; i++)
        //    {

        //        if (i % 2 == 0)
        //        {
        //            money1 = (money1 + inc) - 1;
        //            inc = inc + 10;
        //        }
        //        else
        //        {
        //            toy = toy + price;
        //        }
        //    }
        //    return total = toy + money1;

        //}
        //static void Task2()
        //{
        //    Console.WriteLine("hello world!");
        //    Console.WriteLine("hello world!");
        //}
        //static void Task3()
        //{
        //    int variable = 7;
        //    Console.WriteLine("Value:");
        //    Console.Write(variable);
        //}
        //static void Task4()
        //{
        //    string  variable ="I am a String";
        //       Console.WriteLine("Value:");
        //       Console.Write(variable);

        //}
        static void Task5()
        {
           char  variable ='A';
              Console.WriteLine("Character:");
               Console.Write(variable);

        }
        //static void Task6()
        //{
        //    float variable = 2.2f;
        //    Console.WriteLine("Decimal:");
        //    Console.Write(variable);

        //}
        //static void Task7()
        //{
        //    string str;
        //    str = Console.ReadLine();
        //    Console.WriteLine("You have been interrupted:");
        //    Console.WriteLine(str);
        //}
        //static void Task8()
        //{
        //    string str;
        //    str = Console.ReadLine();
        //    Console.WriteLine("You have been interrupted:");
        //    int num = int.Parse(str);
        //    Console.WriteLine("THe number is:");
        //    Console.WriteLine(num);
        //}
        //static void Task3()
        //{
        //    float length;
        //  String str;
        //    Console.WriteLine("Enter Length: ");
        //    str = Console.ReadLine();

        //   length = float.Parse(str); 
        //    float area = length * length;
        //    Console.WriteLine("The Area is: ");       
        //   Console.Write(area);
        //}
        //static void Task9()
        //{
        //    string input;
        //    float marks;
        //    Console.Write("Enter the Marks: ");
        //    input = Console.ReadLine();
        //    marks = float.Parse(input);

        //    if (marks > 50)
        //    {
        //        Console.WriteLine("You are Passed");
        //    }
        //    else
        //    {
        //        Console.WriteLine("You are Failed");
        //    }
        //}
        //static void Task10()
        //{
        //    for(int x=0;x<5;x++)
        //    {
        //        Console.WriteLine("welcome jack");
        //    }
        //}

        //static void Task12()
        //{
        //    int sum = 0;
        //    int num;
        //    do
        //    { 
        //        Console.WriteLine("enter numbers:");
        //        num = int.Parse(Console.ReadLine());
        //        sum = sum + num;
        //    }
        //    while (num != -1) ;
        //    sum = sum + 1;
        //        Console.WriteLine("the sum is:" + sum);
        //}
        //static void Task13()
        //{
        //    int[] number = new int[3];
        //    for(int index=0;index<3;index++)
        //    {
        //        Console.WriteLine("enter number{0}:",index);
        //        number[index] = int.Parse(Console.ReadLine());
        //    }
        //    //larger number
        //    int largest = number[0];
        //    for (int index = 1; index < 3; index++)
        //    {
        //        if(number[index]>largest)
        //        {
        //            largest = number[index];
        //        }
        //    }
        //    Console.WriteLine(largest);
        //}
        static void Task14()
        {
            int num1, num2;
            Console.Write("enter first number:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("enter second number:");
            num2 = int.Parse(Console.ReadLine());
            int reslut = Add(num1, num2);
            Console.Write("sum :"+reslut);
        }
        static int Add(int num1,int num2)
        {
            return num1 + num2;
        }
      static int menu()
        {
            Console.WriteLine("1. signin");
            Console.WriteLine("2. signup");
            Console.WriteLine("3. exit");
            int option = int.Parse(Console.ReadLine());
            return option;

        }
        static string parseData(string record, int field)
        { 
        int comma= 1;
        string item = " ";
            for (int x=0; x<record.Length; x++)
            {
                 if (record[x]==',')
                         {
                          comma++;
                          }
               else if (comma== field)
                     {
                      item =item + record[x];
                     }
             }
              return item;
      }
        static void signup(string path, string n, string p)
        { 
           StreamWriter file = new StreamWriter(path, true);
             file.WriteLine(n);
            file.WriteLine(p);
            file.Flush();
             file.Close();
         }
        static void readData(string path, string[] names, string[] password)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                
                    string record;
                    while ((record = fileVariable.ReadLine()) != null)
                    {
                        names[x] = parseData(record, 1);
                        password[x] = parseData(record, 2);
                        x++;
                        if (x >= 5)
                        {
                            break;
                        }
                    }

                    fileVariable.Close();
             }
              else
                {
                    Console.WriteLine("file does not exist");
                }
          
}
    static void signIn(string n, string p, string[] names, string[] password)
    { 
         bool flag = false;
           for (int x=0; x< 5; x++)
          if (n == names[x] && p == password[x])
            { 
          Console.WriteLine("Valid User");
             flag = true;
               }
         if (flag == false)
            { 
            Console.WriteLine("Invalid User");
           }
         Console.ReadKey();
         }
    static void Application()
    {
        string path ="C:\\Users\\hp\\Documents\\2nd semester\\opp and pd\\week1\\task1\\";

            int option; 
            do
        {
            string[] names= new string[5];
            string[] password= new string[5];
           
             readData(path, names,password);
            Console.Clear();
            option = menu();
            Console.Clear();
            if (option== 1)
            {
                Console.WriteLine("Enter Name: ");
                string p = Console.ReadLine();
                string n = Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                signIn(n, p, names, password);
            }
            else if (option== 2)
            {
                Console.WriteLine("Enter New Name: ");
                string n = Console.ReadLine();
                Console.WriteLine("Enter New Password: ");
                string p = Console.ReadLine();
                signup(path, n, p);
            }
        } while (option < 3);

            Console.ReadKey();

    }
        //task15
         
           int miniorder,priceoforder;
        static void loadfile()
        {
            string price, name, order;
            string path = "C:\\Users\\hp\\Documents\\2nd semester\\opp and pd\\week1\\task1\\pizza.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    name = parsedata(record, 1);
                    order =parsedata(record, 2);
                    price = parsedata(record, 3);
                    int num = int.Parse(order);
                    int [] orderprice = new int[num];
                    check(orderprice);
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }
        static void Task15()
        {

            Console.WriteLine("Enter Number of Orders");
            int miniorder = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price of Order");
            int priceoforder = int.Parse(Console.ReadLine());
            loadfile();
            int count = 0;
            string path = "C:\\Users\\hp\\Documents\\2nd semester\\opp and pd\\week1\\task1\\pizza.txt";
            if (File.Exists(path))
            {
                StreamReader File = new StreamReader(path);
                string line;
                while ((line = File.ReadLine()) != null)
                {
                    for (int x = 0; x < miniorder; x++)
                    {
                     int   orderprice [x] = int.Parse(PizzaParseDataSet(set, x));
                        
                        if (orderprice[x] >= priceoforder)
                        {
                            count++;
                        }
                    }

                    if (count >= miniorder)
                    {
                        Console.WriteLine(name);
                    }
                    count = 0;

                }
            }
            else
            {
                Console.WriteLine("File Doesn't Exist");
            }


        }

    }
       
         
        static string parsedata(string line, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < line.Length; x++)
            {
                if (line[x] == ' ')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + line[x];
                }
            }
            return item;
        }
     

   
        static void Main(string[] args)
        {

            // float money, price;
            // int age;
            // Console.WriteLine( "enter your age :");
            //age = int.Parse(Console.ReadLine());
            // Console.WriteLine( "enter price of machine :");
            // money = float.Parse(Console.ReadLine());
            // Console.WriteLine("enter price of unit toy :");
            // price=float.Parse(Console.ReadLine());
            // float final = calculate(age, price);
            // if (final > money)
            // {
            //     float total1 = final - money;
            //     Console.WriteLine("yes!");
            //     Console.WriteLine();
            //     Console.WriteLine("{0} left",total1);
            // }
            // else
            // {
            //     float total1 = money - final;
            //     Console.WriteLine("No!");
            //     Console.WriteLine();
            //    Console.WriteLine (total1);

            // }
            // Task2();
            // Task3();
            //Task4();
            // Task5();
            // Task6();
            // Task7();
            //Task8();
            //Task3();
            //Task9();
            // Task10();
            //Task11();
            //  Task12();
            // Task13();
            // Task14();
           // Application();
            Task15();
            Console.ReadKey();
        }
    }
}
