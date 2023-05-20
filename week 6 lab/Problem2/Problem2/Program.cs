using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Problem2.BL;
namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] triangle = new char[5, 3] { { '@', ' ', ' ' }, { '@', '@', ' ' }, { '@', '@', '@' }, { '@', '@', ' ' }, { '@', ' ', ' ' } };
            char[,] optriangle = new char[5, 3] { { ' ', ' ', '@' }, { ' ', '@', '@' }, { '@', '@', '@' }, { ' ', '@', '@' }, { ' ', ' ', '@' } };
            Boundary b = new Boundary(new Point(0, 0), new Point(90, 0), new Point(0, 90), new Point(90, 90));
            Gameobject g1 = new Gameobject(triangle, new Point(10, 30),b,"Lefttoright");
             Gameobject g2 = new Gameobject(optriangle, new Point(15, 40),b,"Righttoleft");
            Gameobject g3 = new Gameobject(optriangle, new Point(20, 40), b, "Diagonal");
            Gameobject g4 = new Gameobject(optriangle, new Point(25, 40), b, "Patrol");
            Gameobject g5= new Gameobject(optriangle, new Point(30, 40), b, "Projectile");
            List<Gameobject> lst = new List<Gameobject>() {g1,g2,g3,g4,g5 };

            while (true)
            {
                Thread.Sleep(1000);

                foreach (Gameobject x in lst)
                {
                    x.Erase();
                    x.Move();
                    x.Draw();
                }
            }
        }
    }
}
