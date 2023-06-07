using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_3.BL;
using Problem_3.Dl;
namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat("i");
            Cat c1 = new Cat("love");
            Dog d = new Dog("myself");
            Dog d1 = new Dog("only");
            AnimalDL.addlist(c);
            AnimalDL.addlist(c1);
            AnimalDL.addlist(d);
            AnimalDL.addlist(d1);
            foreach(Animal p in AnimalDL.animal)
            {
                p.greet();
                Console.WriteLine( p.tostring());
            }
            Console.ReadKey();
        }
    }
}
