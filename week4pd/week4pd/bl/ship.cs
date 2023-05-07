using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4pd.bl
{
    class Ship
    {
        public string number;
        public Angle longitude;
        public Angle latitude;
        public List<Ship> ships= new List<Ship>();
        public Ship(string number,Angle longitude, Angle latitude)
        {
            
            this.number = number;

            this.longitude = longitude;
            this. latitude = latitude;

        }
        public void addship(List<Ship> ships,Ship S3)
        {
            ships.Add(S3);
        }
        public string SerialNumber()
        {
            return this.number;
        }

    }
}
