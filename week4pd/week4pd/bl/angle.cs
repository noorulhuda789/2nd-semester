using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4pd.bl
{

    class Angle
    {
        public int degree;
        public float minutes;
        public char direction;
 
        public string number;

        public Angle(int degree, float minutes, char direction)
        {
            
            this.degree = degree;
            this.minutes = minutes;
            this.direction = direction;

        }
        public Angle()
            {
               }
        // public string format()
        //{
        //    return ships[i].latitude.degree + " ^" + ships[i].latitude.minutes + "'");
        //}
            

        
    }
}
