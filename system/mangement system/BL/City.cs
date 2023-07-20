using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buiness.Dlofcustomer;
namespace Buiness.Bl
{
    class City : Aeroplane
    {
        private string arrival;
        private string departure;
        private string  price;

        public City(string arrival, string departure, string price, string code) : base(code)
        {
            this.arrival = arrival;
            this.price = price;
            this.departure = departure;

        }
        public string getArrival()
        {
            return arrival;

        }
        public void setArrival(string arrival)
        {
            this.arrival = arrival;
        }
        public string getDeparture()
        {
            return departure;

        }
        public string getPrice()
        {
            return price;
        }
        public void setDeparture(string departure)
        {
            this.departure = departure;
        }
        public void setPrice(string price)
        {
            this.price = price;
        }


    }
}
