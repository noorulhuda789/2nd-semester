using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4pd.bl;
namespace week4pd
{
    class Program
    {
        static List<Ship> ships = new List<Ship>();
        static void Main(string[] args)
        {
            int i;
            do
            {
                Console.Clear();
                i = menu();
                if (i >= 1 && i <= 4)
                {
                    if (i == 1)
                    {
                        Console.Clear();
                        Ship s = addship();
                        s.addship(ships, s);
                        Console.WriteLine(ships.Count);
                        
                    }
                    else if (i == 2)
                    {
                        Console.Clear();
                        veiw(ships);

                    }
                    else if(i==3)
                    {
                        Console.Clear();
                        SearchShipByAngle(ships);
                    }
                    else
                    {
                        Console.Clear();
                        update(ships);
                    }

                }
                else
                {
                    Console.WriteLine("invalid input");
                }

                Console.ReadKey();
            } while (i != 5);
            Console.ReadKey();
        }
            static int menu()
            {
            Console.WriteLine("1. ADD ship ");
            Console.WriteLine("2. Serach by serial number  ");
            Console.WriteLine("3. Serach by longitude and latitude  ");
            Console.WriteLine("4. update ships");
            Console.WriteLine("5. Exit  ");
            Console.WriteLine("enter your choice");
            int num= int.Parse(Console.ReadLine());
            return num;


        }
        static Ship addship()
        {
            string name;
            int degree;
            float minutes;
            char direction;

            Console.WriteLine("enter ship number");
            name = Console.ReadLine();
            Console.WriteLine("enter longitude directions(0-180)");
            Console.WriteLine("enter degree(");
            degree = int.Parse(Console.ReadLine());
            Console.WriteLine("enter minutes");
            minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("enter direction(N or S)");
            direction = char.Parse(Console.ReadLine());
            Angle longitude = new Angle(degree, minutes, direction);
           
            Console.WriteLine("enter lattitude directions(0-90)");
            Console.WriteLine("enter degree");
            degree = int.Parse(Console.ReadLine());
            Console.WriteLine("enter minutes");
            minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("enter direction(e or w)");
            direction = char.Parse(Console.ReadLine());
            Angle latitude = new Angle(degree, minutes, direction);
            
            Ship S3 = new Ship(name, longitude, latitude);

            return S3;
           

        }
        static void veiw(List<Ship>ships)
        {
            string number;
            Console.WriteLine("enter ship number");
            number = Console.ReadLine();

            for (int i = 0; i < ships.Count; i++)
            {
                if (number == ships[i].number)
                {
                    Console.WriteLine(ships[i].number);
                    string angle = ships[i].longitude.degree.ToString() + "\u00b0" + ships[i].longitude.minutes.ToString() + "'" + ships[i].longitude.direction.ToString();
                    string angle2= ships[i].latitude.degree.ToString() + "\u00b0" + ships[i].latitude.minutes.ToString() + "'" + ships[i].latitude.direction.ToString();
                    Console.WriteLine(angle + "  and  " + angle2);

                }

            }



        }
        static void SearchShipByAngle(List<Ship> ships)
        {
            int Longitudedegree;
            float Longitudeminutes;
            char Longitudedirection;

            int Latitudedegree;
            float Latitudeminutes;
            char Latitudedirection;

            Console.WriteLine("Enter Ship Latitude: ");
            Console.Write("Enter Ship Latitude 's Degree: ");
            Latitudedegree = int.Parse(Console.ReadLine());
            Console.Write("Enter Ship Latitude 's Minutes: ");
            Latitudeminutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Ship Latitude 's Direction: ");
            Latitudedirection = char.Parse(Console.ReadLine());

            Angle Latitude = new Angle(Latitudedegree, Latitudeminutes, Latitudedirection);

            Console.WriteLine("Enter Ship Longitude: ");
            Console.Write("Enter Ship Longitude 's Degree: ");
            Longitudedegree = int.Parse(Console.ReadLine());
            Console.Write("Enter Ship Longitude 's Minutes: ");
            Longitudeminutes = float.Parse(Console.ReadLine());
            Console.Write("Enter Ship Longitude 's Direction: ");
            Longitudedirection = char.Parse(Console.ReadLine());

            Angle Longitude = new Angle(Longitudedegree, Longitudeminutes, Longitudedirection);

            string S = SearchbyCoordinates(Latitude, Longitude, ships);

            
            Console.WriteLine("Serial Number of the Ship is {0}", S);
        }
            static string SearchbyCoordinates(Angle A, Angle B, List<Ship> Ships)
        {
            for (int x = 0; x < Ships.Count; x++)
            {
                if ((A.degree == Ships[x].longitude.degree && A.minutes == Ships[x].longitude.minutes && A.direction == Ships[x].longitude.direction) && (B.degree == Ships[x].latitude.degree && B.minutes == Ships[x].latitude.minutes && B.direction == Ships[x].latitude.direction))
                {
                    return Ships[x].number;
                }
            }
            return null;
        }

        static void update(List<Ship> ships)
        {
            string name;
            int degree;
            float minutes;
            char direction;
            string number;
            Console.WriteLine("enter ship number");
            number = Console.ReadLine();
            for (int i = 0; i < ships.Count; i++)
            {
                if (number == ships[i].number)
                {

                    Console.WriteLine("enter ship number");
                    name = Console.ReadLine();
                    Console.WriteLine("enter longitude directions");
                    Console.WriteLine("enter degree");
                    degree = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter minutes");
                    minutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("enter direction");
                    direction = char.Parse(Console.ReadLine());
                    ships[i]. longitude = new Angle(degree, minutes, direction);

                    Console.WriteLine("enter lattitude directions");
                    Console.WriteLine("enter degree");
                    degree = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter minutes");
                    minutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("enter direction");
                    direction = char.Parse(Console.ReadLine());
                    ships[i]. latitude = new Angle(degree, minutes, direction);
                    
                }
            }

        }
    }
}
