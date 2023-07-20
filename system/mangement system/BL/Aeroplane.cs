using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buiness.Dlofcustomer;
namespace Buiness.Bl
{
    class Aeroplane
    {

        private string name;
        private int noofseats;
        private int priceofseats;
        private string code;

        public Aeroplane(string name, int noofseats, int priceofseats, string code)
        {
            this.name = name;
            this.noofseats = noofseats;
            this.priceofseats = priceofseats;
            this.code = code;
            //this.city = city;
        }
        public string getName()
        {
            return name;
        }
        public string getCode()
        {
            return code;
        }
        public int getSeats()
        {
            return noofseats;
        }
        public int getPrice()
        {
            return priceofseats;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setCode(string code)
        {
            this.code = code;
        }
        public void setSeats(int noofseats)
        {
            this.noofseats = noofseats;
        }
        public void setPrice(int priceofseats)
        {
            this.priceofseats = priceofseats;
        }

        public Aeroplane()
        {

        }
        public Aeroplane(string code)
        {
            this.code = code;

        }


    }
}
