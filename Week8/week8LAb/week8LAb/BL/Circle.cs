using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8LAb.BL
{
    class Circle
    {
        protected double radius = 1.0;
       protected string color = "red";
        public Circle()
        {
            this.radius = 1.0;
            this.color = "red";

        }
        public Circle(double radius)
        {
            this.radius = radius;

        }
        public Circle(double radius,string color)
        {
            this.radius = radius;
            this.color = color;

        }
        public double getradius()
        {
            return radius;
        }
        public void setradius(double radius)
        {
            this.radius = radius;

        }
        public string getcolor()
        {
            return color;
        }
        public void setcolor(string color)
        {
            this.color =color;

        }
        public double getarea()
        {
            return 3.14 * radius * radius;
        }
        public string tostring()
        {
            return"color[" +color+ ","+ radius+"]";
        }
    }
}
