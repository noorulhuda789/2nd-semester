using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.BL
{
    class Point
    {
        public int x;
        public int y;
        public Point()
        {
            x = 0;
            y = 0;

        }
        public Point (int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getx()
        {
            return x;
        }

        public int gety()
        {
            return y;
        }
        public void setx(int x)
        {
            this.x = x;
        }
        public void sety(int y)
        {
            this.y = y;
        }
        public void setboth(int x,int y)
        {

            this.x = x;
            this.y = y;
        }
    }
}
