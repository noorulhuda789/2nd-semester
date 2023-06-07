using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8LAb.BL
{
    class Clyinder:Circle
    {
        private double height = 1.0;
        public Clyinder()
        {
            this.height = 1.0;

        }
        public Clyinder(double radius):base(radius)
        {
            
        }
        public Clyinder(double radius,double height) : base(radius)
        {

            this.height=height;
        }
        public Clyinder(double radius, double height,string color) : base(radius,color)
        {
            this.height = height;
        }
        public double getheoight()
        {
            return height;
        }
        public void setheight(double height)
        {
            this.height = height;
        }
        public double getvolume()
        {
            return base.getarea ()*height ;
        }


    }
}
