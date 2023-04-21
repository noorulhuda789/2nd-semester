using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week2.Bl;
using System.IO;
namespace week2
{
   
    class Program
    {
        class Student
        {
            public string name;
            public int rollnumber;
            public float cgpa;
            
        }
        static void Task1()
        {
            Student s1 = new Student();
            s1.name = "john";
            s1.rollnumber = 12;
            s1.cgpa = 3.25F;
            Console.WriteLine("name  rollnumber  cgpa   "+s1.name+ s1.rollnumber+ s1.cgpa);
            

        }
        static void Task2()
        {
            //first object
            Student s1 = new Student();
            s1.name = "john";
            s1.rollnumber = 12;
            s1.cgpa = 3.25F;
            Console.WriteLine("name  rollnumber  cgpa   " + s1.name + s1.rollnumber + s1.cgpa);
            //second object
            Student s2 = new Student();
            s2.name = "Noor";
            s2.rollnumber = 12;
            s2.cgpa = 3.25F;
            Console.WriteLine("name  rollnumber  cgpa   " + s2.name + s2.rollnumber + s2.cgpa);

        }
        static void Task3()
        {
            Student s1 = new Student();
            Console.WriteLine("enter your name:");
           s1.name = Console.ReadLine();
            Console.WriteLine("enter your roll number:");
            s1.rollnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your cpa:");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("name  rollnumber  cgpa   " + s1.name + s1.rollnumber + s1.cgpa);
        }
        static int menu()
        {
            int choice;
            Console.Clear();
            Console.WriteLine("1.Add student");
            Console.WriteLine("2. View student");
            Console.WriteLine("3. Top student");
            Console.WriteLine("4. Exit");
            Console.WriteLine("enter choice");
            choice = int.Parse(Console.ReadLine());
            return choice;

        }
        static Class1 addstudent()
        {
            Console.Clear();
            Class1 s1 = new Class1();
            Console.WriteLine("enter your name:");
            s1.name = Console.ReadLine();
            Console.WriteLine("enter your roll number:");
            s1.rollnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your cpa:");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("enter Department:");
            s1.department= Console.ReadLine();
            Console.WriteLine("Is hostelite y\\n");
            s1.hostel = char.Parse(Console.ReadLine());
            return s1;
        }
        static void veiw(Class1[]s,int count)
        {
            Console.Clear();
            for(int i=0;i<count;i++)
            {
                Console.WriteLine("name :{0}  roll number:{1}  Cgpa:{2} Department:{3}  Hostel:{4}", s[i].name, s[i].rollnumber, s[i].cgpa, s[i].department, s[i].hostel);
            }
            Console.WriteLine("pree any key to continue");
            Console.ReadKey();
        }
        static void top(Class1[] s, int count)
        {
            Console.Clear();
            if(count==0)
            {
                Console.WriteLine("no record present");
            }
            else if(count==2)
            {
                for(int i=0;i<2;i++)
                {
                    int index = largest(s, i, count);
                    Class1 temp = s[index];
                    s[index] = s[i];
                }
                veiw(s, 2);
            }
            else if (count == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    int index = largest(s, i, count);
                    Class1 temp = s[index];
                    s[index] = s[i];
                }
                veiw(s, 3);
            }
        }
        static int largest(Class1[] s, int count,int end)
        {
            int index = count;
            float large = s[count].cgpa;
            for(int i=count;i<end; i++)
            {
                if(large<s[i].cgpa)
                {
                    large = s[i].cgpa;
                    index = i;
                }
            }
            return index;
        }
        static void Task4()
        {
            int count = 0;
            Class1[] s1 = new Class1[10];
            int num;
            do
            {
                 num = menu();
                if (num == 1)
                {
                   s1[count]= addstudent();
                    count = count + 1;
                }
                else if (num == 2)
                {
                    veiw(s1,count);
                }
                else if (num == 3)
                {
                    top(s1,count);
                }
                else
                {
                    break;
                }
              
            }
            while (num != 4);
        }
       static void Task5()
        {
            Store[] s1 = new Store[10];
            int num,count=0;
            do
            {
                num = menu();
                if (num == 1)
                {
                    s1[count] = addproduct();
                    count = count + 1;
                }
                else if (num == 2)
                {
                    veiwproduct(s1, count);
                }
                else if (num == 3)
                {
                    sum(s1, count);
                }
                else
                {
                    break;
                }

            }
            while (num != 4);
        }
        static Store addproduct()
        {
            Console.Clear();
            Store s1 = new Store();
            Console.WriteLine("enter Product id :");
            s1.productid = Console.ReadLine();
            Console.WriteLine("enter Product name:");
            s1.name = Console.ReadLine();
            Console.WriteLine("enter price:");
            s1.price = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Brand name:");
            s1.brand= Console.ReadLine();
            Console.WriteLine("enter category");
            s1.category = Console.ReadLine();
            Console.WriteLine("enter country name:");
            s1.country = Console.ReadLine();
            return s1;
        }

        static int menu1()
        {
            int choice;
            Console.Clear();
            Console.WriteLine("1.Add product");
            Console.WriteLine("2. View product");
            Console.WriteLine("3. Total price");
            Console.WriteLine("4. Exit");
            Console.WriteLine("enter choice");
            choice = int.Parse(Console.ReadLine());
            return choice;

        }
        static void veiwproduct(Store[] s, int count)
        {
            Console.Clear();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("product id:{0}  Product name:{1} Price:{2} Brand name:{3}  Catergory:{4} country name : {5}", s[i].productid, s[i].name, s[i].price, s[i].brand, s[i].category, s[i].country);
            }
            Console.WriteLine("pree any key to continue");
            Console.ReadKey();
        }
        static void sum(Store[] s, int count)
        {
            int sum = 0;
            for(int x=0;x<count;x++)
            {
                sum = sum + s[x].price;
            }
            Console.WriteLine("total price:{0}", sum);
        }
        static void Task6()
        {
            string path = "C:\\Users\\hp\\Documents\\2nd semester\\opp and pd\\week1\\task1\\textfile.txt";
            

            int num, count = 0;

            List<Signin> C = new List<Signin>();
            bool reslut = readData(path, C);
            Console.Clear();
            if (reslut == true)
            {
                do {
                    num = menu2();
                    Console.Clear();
                    if (num == 1)
                    {
                        Console.WriteLine("Enter Name: ");
                        string p = Console.ReadLine();
                        
                        Console.WriteLine("Enter Password: ");
                        string n = Console.ReadLine();
                        signIn(n, p,C );
                    }
                    else if (num == 2)
                    {
                        Console.WriteLine("Enter New Name: ");
                        string n = Console.ReadLine();
                        Console.WriteLine("Enter New Password: ");
                        string p = Console.ReadLine();
                        signup(path, n, p);
                    }
                    else
                    {
                        break;
                    }


                }
                while (num != 4);

            }
        }
        static int menu2()
        {
            int choice;
            Console.Clear();
            Console.WriteLine("1.Signin");
            Console.WriteLine("2. Signup");
          
            Console.WriteLine("4. Exit");
            Console.WriteLine("enter choice");
            choice = int.Parse(Console.ReadLine());
            return choice;

        }
        static bool readData(string path, List<Signin> users)
        {
            bool reslut = true;
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);

                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    
                    Signin User = new Signin();
                    User.name = parseData(record, 1);
                    User.password = parseData(record, 2);
                    users.Add(User);
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
            return reslut;
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = " ";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static void signIn(string n, string p, List<Signin> users)
        {
           
            bool flag = false;
            for (int x = 0; x < users.Count; x++)
            {
                Console.WriteLine(users[x].password);
                if (n == users[x].name && p == users[x].password)
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();

        }
        static void signup(string path, string n, string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n+","+ p);
          
            file.Flush();
            file.Close();
        }
        static void Main(string[] args)
        {
            // Task1();
            //Task2();
            // Task3();
            //Task4();
            // Task5();
            Task6();
            Console.ReadKey();
        }
    }
}
