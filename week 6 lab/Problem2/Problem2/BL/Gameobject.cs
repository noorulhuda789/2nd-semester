using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.BL
{
    class Gameobject
    {
         bool reslut = true;
        int counter=1;
        
        public char[,] game;
        public Boundary premise;
        public Point startingpoint;
        public string direction;
        public Gameobject()
        {
            game = new char[,] { { '-', '-', '-' } };
            startingpoint.x = 0;
            startingpoint.y = 0;
            this.premise = new Boundary();
            direction = "Lefttoright";
        }
        public  Gameobject(char[,] game, Point startingpoint,Boundary premise,string direction)
        {
            this.game = game;
            this.startingpoint = startingpoint;
            this.premise = premise;
            this.direction = direction;
        }
        public void Move()

        {

            if(this.direction=="Lefttoright")
            {
                if(startingpoint.x>=0 && startingpoint.x <=premise.topright.x)
                {
                    startingpoint.x++;
                }

            }
            if (this.direction == "Righttoleft")
            {
                if (startingpoint.x > 0 && startingpoint.x > premise.topleft.x)
                {
                    startingpoint.x--;
                }

            }
            if (this.direction == "Diagonal")
            {
                if (startingpoint.x > 0 && startingpoint.x <= premise.bottomright.x && startingpoint.y<= premise.bottomright.y)
                {
                    startingpoint.x++;
                    startingpoint.y++;

                }

            }
            if (this.direction == "Patrol")
            {
                
                if (reslut == true)
                {
                    startingpoint.x++;
                    if (startingpoint.x == premise.topright.x)
                    {
                        reslut = false;
                    }

                }

                else
                {
                    startingpoint.x--;

                    if (startingpoint.x == premise.topleft.x)
                    {
                        reslut = true;
                    }

                }

            }
            if (this.direction == "Projectile")
            {
               if( counter>=1 && counter<=5)
                {
                    startingpoint.x++;
                    startingpoint.y--;
                    counter++;
                }
               else  if (counter >= 6 && counter <= 7)
                {
                    startingpoint.x++;
                    counter++;
                }

                else if(counter >= 8 && counter <= 11)
                {
                    startingpoint.x++;
                    startingpoint.y++;
                    counter++;
                    if (counter==12)
                    {
                        counter = 1;
                    }

                }

            }
        }
        public  void  Erase( )
        {
            int x = startingpoint.x;
            int y = startingpoint.y;

            for (int i = 0; i < game.GetLength(0); i++)
            {

                Console.SetCursorPosition(x, y + i);
                for (int j = 0; j < game.GetLength(0); j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
        public   void Draw()
        {
            int x = startingpoint.x;
            int y = startingpoint.y;

            for(int i=0;i<game.GetLength(0);i++)
            {

                Console.SetCursorPosition(x, y + i);
                for (int j = 0; j < game.GetLength(1); j++)
                {
                    Console.Write(game[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
