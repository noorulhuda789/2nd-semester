using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.BL
{
    class Circle:Shape
    {
        private float radius;
        public Circle(float radius,string objecttype):base(objecttype)
        {
            this.radius = radius;
        }
        public override double getarea()
        {
            return 3.14*radius * radius*2;
        }
        public override string tostring()
            {
            return "the shape is " + objecttype + " its is area  is " + getarea();
        }
    }
}
