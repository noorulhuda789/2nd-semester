using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace business
{
    class Program
    {

        static int count = 0, countforcitytogo = 0, row = 0, column = 0, countforhotel = 0;

        static string[] hotelname = new string[100];
        static int[] hotelprice = new int[100];

        static void Main(string[] args)
        {

            loadfileforhotel();

            Application();


            Console.ReadKey();
        }

        //admin functionalities

        static void checkcondition1(int check)
        {

            if (check >= 1 && check <= 4)
            {
                while (check != -1)
                {

                    if (check == 1)
                    {
                        viewhotel();
                    }

                    else if (check == 2)
                    {
                        addhotel();

                    }

                    else if (check == 3)
                    {
                        deletehotel();

                    }

                    else
                    {
                        updatepriceofhotel();

                    }
                }
            }
            else
            {
                Console.Write("invalid input");
                hotel();
            }
        }

        static void hotel()
        {
            Console.Clear();
            string input;
            Console.SetCursorPosition(4, 8);
            Console.Write("1 .if you want to view all hotels ");
            Console.SetCursorPosition(4, 10);
            Console.Write("2. if you want to add hotels :");
            Console.SetCursorPosition(4, 12);
            Console.Write("3. if you ant to remove hotel:");
            Console.SetCursorPosition(4, 14);
            Console.Write("4. if you want to update price of hotel:");
            Console.SetCursorPosition(4, 16);
            Console.Write("enter your choice:");
            input = Console.ReadLine();
            if (int.
                 TryParse(input, out int num))
            {
                checkcondition1(num);
            }
            else
            {
                Console.Write("invalid input");
                hotel();
            }
            System.Threading.Thread.Sleep(500);

        }

        static void loadfileforhotel()
        {
            string path = "C:\\Users\\hp\\Documents\\2nd semester\\opp and pd\\week1\\business\\business\\hotel.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);

                string name;

                while (!(fileVariable.EndOfStream))
                {
                    name = fileVariable.ReadLine();
                    if (name != " ")
                    {
                        string[] splitarray = name.Split(',');

                        hotelname[countforhotel] = splitarray[0];
                        hotelprice[countforhotel] = int.Parse(splitarray[1]);
                        countforhotel++;
                    }
                }
                fileVariable.Close();
            }
        }
        static void storefile()
        {

            string path = "C:\\Users\\hp\\Documents\\2nd semester\\opp and pd\\week1\\business\\hotel.txt";
            StreamWriter fileVariable = new StreamWriter(path);
            for (int x = 0; x < countforhotel; x++)
            {
                fileVariable.Write(hotelname[x]);
                fileVariable.Write(",");
                fileVariable.Write(hotelprice[x]);
                fileVariable.WriteLine();
            }
            fileVariable.Close();
        }
        //functionalities
        static void viewhotel()
        {
            Console.Clear();
            Console.SetCursorPosition(4, 20);
            Console.Write("hotel name              hotel price");
            for (int i = 0; i < countforhotel; i++)
            {
                Console.Write(hotelname[i]);
                Console.Write("         ");
                Console.Write(hotelprice[i]);
                Console.WriteLine();

            }
        }

        static void addhotel()
        {
            viewhotel();
            countforhotel = countforhotel + 1;
            Console.SetCursorPosition(4, countforhotel + 2);
            Console.Write("add hotel:");
            hotelname[countforhotel] = Console.ReadLine();
            Console.SetCursorPosition(4, countforhotel + 4);
            Console.Write("enter hotel price:");
            hotelprice[count] = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(4, countforhotel + 6);
            Console.Write("hotel is added sucessfully");

            storefile();
        }
        static void deletehotel()
        {
            int i = 0;
            bool check;
            string hotelnameis;
            viewhotel();
            Console.SetCursorPosition(4, countforhotel + 2);
            Console.Write("which hotel you want to delete:");
            hotelnameis = Console.ReadLine(); ;
            check = hotelcheck(hotelnameis);
            if (check == true)
            {
                while (i < count)
                {
                    if (hotelnameis == hotelname[i])
                    {
                        for (int j = i; j < countforhotel - 1; j++)
                        {
                            hotelname[j] = hotelname[j + 1];

                            hotelprice[j] = hotelprice[j + 1];
                        }
                    }
                    else
                    {
                        i++;
                    }

                    countforhotel--;
                }
            }
            else
            {
                Console.SetCursorPosition(4, countforhotel + 2);
                Console.Write("invalid input");
                deletehotel();
            }
            storefile();
        }
        static void updatepriceofhotel()
        {
            bool check;
            int count = 0;
            viewhotel();
            Console.SetCursorPosition(4, countforhotel + 2);
            string hotelnameis;
            Console.Write("which hotel's price you want to update:");
            hotelnameis = Console.ReadLine();
            check = hotelcheck(hotelnameis);
            if (check == true)
            {
                for (int c = 0; c < countforhotel; c++)
                {
                    if (hotelnameis != hotelname[c])
                    {
                        count = count + 1;
                    }
                    if (hotelnameis == hotelname[c])
                    {
                        break;
                    }
                }
                Console.SetCursorPosition(4, countforhotel + 4);
                Console.Write("enter price:");
                hotelprice[count] = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.SetCursorPosition(4, countforhotel + 4);
                Console.Write("invalid hotel name");
                updatepriceofhotel();
            }
            storefile();
        }
        static bool hotelcheck(string hotelnamie)
        {
            bool flag = false;
            for (int i = 0; i < countforhotel; i++)
            {
                if (hotelnamie == hotelname[i])
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        static int menu()
        {
            header();
            Console.WriteLine("1. signin");
            Console.WriteLine("2. signup");
            Console.WriteLine("3. exit");
            int option = int.Parse(Console.ReadLine());
            return option;

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
        static void signup(string path, string n, string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);
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
            for (int x = 0; x < 5; x++)
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
            string path = "C:\\Users\\hp\\Documents\\2nd semester\\opp and pd\\week1\\task1\\";

            int option;
            do
            {
                string[] names = new string[5];
                string[] password = new string[5];

                readData(path, names, password);
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("Enter Name: ");
                    string p = Console.ReadLine();
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    signIn(n, p, names, password);
                    hotel();
                }
                else if (option == 2)
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
        static void header()
        {
            Console.WriteLine("        ##################   ############        ######    #    #     ######   ################## ");
            Console.WriteLine("                #                 #            #           #   #      #                 #");
            Console.WriteLine("                #                 #           #            #  #       #                 #");
            Console.WriteLine("                #                 #           #            # #        ######            # ");
            Console.WriteLine("                #                 #           #            # #        #                 #");
            Console.WriteLine("                #                 #            #           #   #      #                 # ");
            Console.WriteLine("                #            ############       #######    #     #    ######            #");


            Console.WriteLine("        ######   #      #     ######     ##################    ######     #           # ");
            Console.WriteLine("       #          #    #     #                   #             #          #  #     #  # ");
            Console.WriteLine("         #          #          #                 #             #          #     #     #  ");
            Console.WriteLine("           #        #            #               #             ######     #           #  ");
            Console.WriteLine("             #      #              #             #             #          #           #  ");
            Console.WriteLine("              #     #                #           #             #          #           #  ");
            Console.WriteLine("         #####      #          ######            #             ######     #           #   ");

        }
    }
}





