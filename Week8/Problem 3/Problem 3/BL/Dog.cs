using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.BL
{
    class Dog:Mammal
    {
        public Dog(string name) : base(name)
        {

        }
        public override void  greet()
        {
            Console.WriteLine("whoo whoo");
        }
        public override string tostring()
        {
            return "Dog: Mammal:Animal  " + base.name;
        }
    }
}
