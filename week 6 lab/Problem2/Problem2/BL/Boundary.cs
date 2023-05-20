using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.BL
{
    class Boundary
    {
        public Point topleft;
        public Point topright;
        public Point bottomleft;
        public Point bottomright;
       
        public Boundary()
        {
            topleft = new Point(0, 0);
            topright = new Point(90, 0);
           bottomleft = new Point(0, 90);
            bottomright = new Point(90, 90);

        }
        public Boundary(Point topleft,Point topright,Point bottomleft,Point bottomright)
        {
            this.topleft = topleft;
            
            this.topright = topright;
            
            this.bottomleft = bottomleft;
            
            this.bottomright = bottomright;
  

        }
    }
}
