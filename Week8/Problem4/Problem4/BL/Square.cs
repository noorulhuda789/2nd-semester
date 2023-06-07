using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.BL
{
    class Square:Shape
    {
        private float height;
        public Square(float height ,string objecttype):base(objecttype)
        {
            this.height = height;

        }
        public override double getarea()
        {
            return height*height;
        }
        public override string tostring()
        {
            return "the shape is " + objecttype + " its is area  is  " + getarea();
        }
    }
}
