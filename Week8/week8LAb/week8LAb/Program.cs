using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week8LAb.BL;

namespace week8LAb
{
    class Program
    {
        static void Main(string[] args)
        {
            
          double height = double.Parse(Console.ReadLine());
           double radius=double.Parse(Console.ReadLine());
            string color = Console.ReadLine();
            Clyinder c = new Clyinder();
            Clyinder c1 = new Clyinder(radius,height);
            Clyinder c2 = new Clyinder(radius, height,color);
            double reslut = c2.getvolume();
            Console.WriteLine(reslut);
            Console.ReadKey();

        }
    }
}
