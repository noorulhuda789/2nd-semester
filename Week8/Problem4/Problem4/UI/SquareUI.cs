using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem4.BL;
namespace Problem4.UI
{
    class SquareUI
    {
        public static Square createSquare()
        {
            Console.WriteLine("enter the side : ");
            float s = float.Parse(Console.ReadLine());
            Square ss = new Square( s,"square ");
            return ss;
        }
    }
}
