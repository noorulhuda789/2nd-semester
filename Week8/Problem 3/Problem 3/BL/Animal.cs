using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.BL
{
    class Animal
    {
        protected string name;
        public Animal(string name)
        {
            this.name=name;
        }
        public virtual string tostring()
        {
            return "Animal  " + name;
        }
        public Animal()
        { }
        public virtual void greet()
        {
            Console.WriteLine("me");

        }

    }
}
