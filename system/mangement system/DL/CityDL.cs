using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buiness.Bl;
using System.IO;
namespace Buiness.Dlofcustomer
{
    class CityDL
    {
        public static List<City> cities = new List<City>();
        public static City Check(string code)
        {
            foreach (City x in cities)
            {
                if (x.getCode() == code)
                {
                    return x;

                }
            }
            return null;

        }

        public static int Checkcount(string code)
        {
            int y = 0;
            foreach (City x in cities)
            {
                if (x.getCode() == code)
                {
                    y++;

                }
            }
            return y;

        }
        public static bool CheckCities(string arrival, string depature)
        {

            foreach (City x in cities)
            {
                if (x.getArrival() == arrival && x.getDeparture() == depature)
                {
                    return true;

                }
            }
            return false;

        }
        public static string Price(string arrival, string depature)
        {


            foreach (City x in cities)
            {
                if (x.getArrival() == arrival && x.getDeparture() == depature)
                {
                    return x.getPrice();

                }
            }
            return null;

        }
        public static bool readData(ref string adpath)

        {
            if (File.Exists(adpath))
            {
                StreamReader fileVariable = new StreamReader(adpath);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] temp = record.Split(',');
                    City s = new City(temp[0], temp[1], temp[2],temp[3]);

                    cities.Add(s);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }

    }
}
