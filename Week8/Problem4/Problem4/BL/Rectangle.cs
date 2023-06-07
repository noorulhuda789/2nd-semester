using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.BL
{
    class Rectangle:Shape
    {
        private float height;
        private float width;
        public Rectangle(float height,float width,string objecttype):base(objecttype)
        {
            this.height = height;
            this.width = width;
        }
        public override double getarea()
        {
            return width * height;
        }
        public override string tostring()
        {
            return "the shape is " + objecttype + " its is area  is " + getarea();
        }
    }
}
