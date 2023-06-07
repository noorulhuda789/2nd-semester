using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.BL
{
    class Cat:Mammal
    {
        public Cat(string name) : base(name)
        {

        }
        public  override void greet()
        {
            Console.WriteLine("meow mewo mewo");
        }
        public override string tostring()
        {
            return "Cat: Mammal:Animal  " + base.name;
        }
    }
}
