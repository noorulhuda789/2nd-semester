using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem4.BL;
namespace Problem4.UI
{
    class CircleUI
    {
        public static Circle createCircle()
        {
            Console.WriteLine("enter the radius : ");
            float r = float.Parse(Console.ReadLine());
            Circle c = new Circle( r,"cicle");
            return c;
        }
    }
}
