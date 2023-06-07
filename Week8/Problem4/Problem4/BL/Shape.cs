using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.BL
{
    class Shape
    {
        protected string objecttype;
        public  Shape (string objecttype)
        {
            this.objecttype = objecttype;
        }
        public virtual double getarea()
        {
            return 1.0;
        }
        public  virtual  string tostring()
        {
            return "me";
        }
    }
}
