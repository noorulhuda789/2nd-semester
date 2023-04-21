using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using business.BL;
using System.IO;
namespace business
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Admin> stu = new List<Admin>();
           load(stu);
             mainscreen(stu);
            Console.ReadKey();
        }
        static int hotel(List<Admin> stu)
        {
            int num;
            string input;
            
                Console.Clear();
                header();
                

                Console.WriteLine("1 .if you want to view all hotels ");

                Console.WriteLine("2. if you want to add hotels :");

                Console.WriteLine("3. if you ant to remove hotel:");

                Console.WriteLine("4. if you want to update price of hotel:");
                Console.WriteLine("press -1 to escape");
                Console.WriteLine("enter your choice:");
                input = Console.ReadLine();
                if (int.
                     TryParse(input, out  num))
                {
                
                }
                else
                {
                    Console.Write("invalid input");
                    hotel(stu);
                }
            return num;
            System.Threading.Thread.Sleep(500);
           
        }
        static void checkcondition1( List<Admin> stu)
        {
            int check;
            do
            {
                 check = hotel(stu);

                if (check >= 1 && check <= 4)
                {


                    if (check == 1)
                    {
                        viewhotel(stu);
                    }

                    else if (check == 2)
                    {
                        addhotel(stu);

                    }

                    else if (check == 3)
                    {
                        deletehotel(stu);

                    }

                    else
                    {
                        updatepriceofhotel(stu);

                    }

                }
                else
                {
                    Console.Write("invalid input");
                    hotel(stu);
                }
            } while (check != -1);
        }
        static void addhotel(List<Admin> stu)
        {
            Console.Clear();
            header();
            Admin s = new Admin();
            viewhotel(stu);

            Console.WriteLine();
            Console.WriteLine("add hotel:");
            s.hotelname = Console.ReadLine();
           
            Console.WriteLine("enter hotel price:");
            s.hotelprice = int.Parse(Console.ReadLine());
            
            Console.Write("hotel is added sucessfully");
            stu.Add(s);
            storefile(stu);
        }
        static void load(List<Admin> stu)
        {
            string path = "C:\\Users\\hp\\Documents\\2nd semester\\opp and pd\\week1\\business\\business\\hotel.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);

                    
                    string name;
                while ((name = fileVariable.ReadLine()) != null)
                {
                    Admin s = new Admin();
                    if (name != null)
                    {
                        string[] splitarray = new string[2];
                        splitarray = name.Split(',');
                        s.hotelname = splitarray[0];
                        s.hotelprice = int.Parse(splitarray[1]);
                        stu.Add(s);
                        
                        s.countforhotel++;
                    }

                }
                fileVariable.Close();
            }
        }
        static void storefile(List<Admin> stu)
        {

            string path = "C:\\Users\\hp\\Documents\\2nd semester\\opp and pd\\week1\\business\\hotel.txt";
            StreamWriter fileVariable = new StreamWriter(path);
            for (int x = 0; x < stu.Count; x++)
            {
                fileVariable.Write(stu[x].hotelname);
                fileVariable.Write(",");
                fileVariable.Write(stu[x].hotelprice);
                fileVariable.WriteLine();
            }
            fileVariable.Close();
        }
        static void viewhotel(List<Admin> stu)
        {
            Console.Clear();
            header();

            Admin s = new Admin();
            Console.Write("hotel name       hotel price");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("         ");
                Console.Write(stu[i].hotelname);
                Console.Write("         ");
                Console.Write(stu[i].hotelprice);
                Console.WriteLine();

            }
        }
        static void deletehotel(List<Admin> stu)
        {
            Console.Clear();
            header();
            Admin s = new Admin();
            int i = 0;
            bool check;
            string hotelnameis;
            viewhotel(stu);
           
            Console.WriteLine("which hotel you want to delete:");
            hotelnameis = Console.ReadLine(); ;
            check = hotelcheck(hotelnameis,stu);
            if (check == true)
            {
               int reslut= hotelnumber(stu, hotelnameis);
                stu.RemoveAt(reslut);
            }
            else
            {
                
                Console.WriteLine("invalid input");
                deletehotel(stu);
            }
            storefile(stu);
        }
        static void updatepriceofhotel(List<Admin> stu)
        {
            Console.Clear();
            header();
            bool check;
            int count = 0;
            viewhotel(stu);
            
            string hotelnameis;
            Console.WriteLine("which hotel's price you want to update:");
            hotelnameis = Console.ReadLine();
            check = hotelcheck(hotelnameis,stu);
            if (check == true)
            {
                int reslut = hotelnumber(stu, hotelnameis);

                Console.WriteLine("enter price:");
                stu[reslut].hotelprice = int.Parse(Console.ReadLine());
            }
            else
            {

                Console.WriteLine("invalid hotel name");
                updatepriceofhotel(stu);
            }
            storefile(stu);
        }
        static bool hotelcheck(string hotelnamie, List<Admin> stu)
        {
            
            bool flag = false;
            for (int i = 0; i <stu.Count; i++)
            {
                if (hotelnamie!= stu[i].hotelname)
                {
                    int count = 1;
                }
                flag = true;
                break;
            }
            return flag;
        }
        static int hotelnumber(List<Admin> stu,string hotelnameie)
        {
            int count = 0;
            Admin s = new Admin();
            for(int i=0;i<s.countforhotel;i++)
            {
                if (hotelnameie != stu[i].hotelname)
                {
                    count++;
                }
            }
            return count;

        }
        static void header()
        {
            Console.WriteLine("  *********************************************************************");

            Console.WriteLine("  *                                                                   * ");

            Console.WriteLine("  *                  TICKET MANAGEMENT STSTEM                         *");

            Console.WriteLine("  *                                                                   * ");

            Console.WriteLine("  ********************************************************************* ");

        }
        static void mainscreen(List<Admin> stu)
        {
            string path = "C:\\Users\\hp\\Documents\\2nd semester\\opp and pd\\week1\\task1\\textfile.txt";

            
            
            int num, count = 0;

            List<Admin> C = new List<Admin>();
            bool reslut = readData(path, C);
            
            if (reslut == true)
            {
                do
                {
                    num = menu2();
                   
                    if (num == 1)
                    {
                        Console.Clear();
                        header();

                        Console.WriteLine("Enter Name: ");
                        string p = Console.ReadLine();

                        Console.WriteLine("Enter Password: ");
                        string n = Console.ReadLine();
                        signIn(n, p, C,stu);
                        
                    }
                    else if (num == 2)
                    {
                        Console.Clear();
                        header();
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
                while (num != 3);

            }
        }
        static int menu2()
        {
            int choice;
            Console.Clear();
            header();
           
            Console.WriteLine("1.Signin");
            Console.WriteLine("2. Signup");

            Console.WriteLine("3. Exit");
            Console.WriteLine("enter choice");
            choice = int.Parse(Console.ReadLine());
            return choice;

        }
        static bool readData(string path, List<Admin> users)
        {
            bool reslut = true;
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);

                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {

                    Admin User = new Admin();
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
            string item = "";
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
        static void signIn(string n, string p, List<Admin> users, List<Admin>stu)
        {

            bool flag = false;
            for (int x = 0; x < users.Count; x++)
            {
                
                if (n == users[x].name && p == users[x].password)
                {
                    
                    Console.WriteLine("Valid User");
                    checkcondition1(stu);
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Invalid User");
                checkcondition1(stu);

            }
            

        }
        static void signup(string path, string n, string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);

            file.Flush();
            file.Close();
        }
    }
}
