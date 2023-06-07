using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem4.BL;
using Problem4.Dl;
using Problem4.UI;
namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = SquareUI.createSquare();
            Rectangle s1 = RectangleUI.createrectangle();
            Circle s3=  CircleUI.createCircle();
            ShapeDl.addlist(s);
            ShapeDl.addlist(s1);
            ShapeDl.addlist(s3);
            foreach(Shape s2 in ShapeDl.shapes)
            {
                Console.WriteLine(s2.tostring());

            }
            Console.ReadKey();
        }
    }
}
