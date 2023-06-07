using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem4.BL;
namespace Problem4.UI
{
    class RectangleUI

    {
        public static Rectangle createrectangle()
        {
            Console.WriteLine("enter the width  :  ");
            float w = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the height  :  ");
            float h = float.Parse(Console.ReadLine());
            Rectangle r = new Rectangle( h, w, "rectangle");
            return r;

        }
    }
}
