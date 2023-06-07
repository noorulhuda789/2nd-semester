using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_3.BL;
namespace Problem_3.Dl
{
    class AnimalDL
    {
        public static List<Animal> animal = new List<Animal>();
        public static void addlist(Animal a)
        {
            animal.Add(a);
        }

    }
}
