using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.BL
{
    class Mammal:Animal
    {
        public Mammal(string name):base(name)
        {

             }
        public override void greet()
        {

        }

        public override string tostring()
        {
            return " Mammal:Animal  " + base.name;
        }
        public Mammal()
        { }

    }
}
