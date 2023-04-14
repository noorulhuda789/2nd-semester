using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;
using System.IO;
using System.Threading;
namespace game
{
    class Program
    {
        static int bulltmovex = heroX + 2;
        static int bulltmovey = 180;
       
        // Player Bullets
        static int[] bulletX = new int[100];
        static int[] bulletY = new int[100];
        static bool[] isBulletActive = new bool[100];
        static int bulletcount = 0;
        static int heroX = 20;
        static int heroY = 40;
        static string[] hero1 = new string[] { "_", "_", "|", "_", "_" };
        static string[] hero2 = new string[] { "-", "-", "o", "-", "-", "(", "_", ")", "-", "-", "o", "-", "-" };
        // static string[] maze = new string[62];
        static char[,] maze = new char[44, 90];


        static void printmaze()
        {


            // fill the maze array with characters
            for (int i = 0; i < 44; i++)
            {
                for (int j = 0; j < 90; j++)
                {
                    if ((i % 2 == 0 && j % 185 == 0) || (i % 2 == 1 && j % 185 == 44))
                    {
                        maze[i, j] = '/';
                    }
                    else if ((i % 2 == 0 && j % 185 == 44) || (i % 2 == 1 && j % 185 == 0))
                    {
                        maze[i, j] = '\\';
                    }
                    else
                    {
                        maze[i, j] = ' ';
                    }
                }
            }

            // print the maze array
            for (int i = 0; i < 44; i++)
            {
                for (int j = 0; j < 90; j++)
                {

                    Console.Write(maze[i, j]);

                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {


            printmaze();
            printhero();

            while (true)
            {
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    //moveheroUp();
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    //moveherodown();
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {

                    moveheroLeft();
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    //moveheroRight();
                }
                if (Keyboard.IsKeyPressed(Key.Space))
                {
                    generateBullet();
                }

            }
            Thread.Sleep(500);
            Console.ReadKey();

        }

        static void printhero()
        {
            Console.SetCursorPosition(heroX, heroY);
            for (int i = 0; i < hero1.Length; i++)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(hero1[i]);
            }

            
            Console.SetCursorPosition(heroX - 4, heroY + 1);
            for (int i = 0; i < hero2.Length; i++)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(hero2[i]);
            }
        }
        static void erasehero()
        {
            Console.SetCursorPosition(heroX, heroY);
            for (int i = 0; i < hero1.Length; i++)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("  ");
            }

            Console.WriteLine();
            Console.SetCursorPosition(heroX - 4, heroY + 1);
            for (int i = 0; i < hero2.Length; i++)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("  ");
            }
        }

        //static void moveheroUp()
        // {
        //     char next = Substring(heroX, heroY - 1);
        //     if (next == ' ')
        //     {
        //         erasehero();
        //         heroY = heroY - 1;
        //         printhero();
        //     }
        // }
        static void moveheroLeft()
        {

            if (maze[heroY, heroX - 1] == ' ')
            {
                erasehero();
                heroX = heroX - 1;

                printhero();
            }

        }
        static void generateBullet()
        {
            bulletX[bulletcount] = heroX + 3;
            bulletY[bulletcount] = heroY - 1;
            isBulletActive[bulletcount] = true;
            Console.SetCursorPosition(heroX + 3, heroY - 1);
            Console.Write(".");
            bulletcount++;
        }
        static void printBullet(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(".");
        }
        static void eraseBullet(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }

        static void makeBulletInactive()
        {
            int index = 0;
            isBulletActive[index] = false;
        }
        static void moveBullet()
        {
            for (int x = 0; x < bulletcount; x++)
            {
                if (isBulletActive[x] == true)
                {
                    
                    if (maze[bulletY[x] - 1, bulletX[x]] ==' ')
                    {
                        eraseBullet(bulletX[x], bulletY[x]);
                        bulletY[x] = bulletY[x] - 1;
                        printBullet(bulletX[x], bulletY[x]);
                        
                    }
                    else
                    {
                        eraseBullet(bulletX[x], bulletY[x]);
                        makeBulletInactive();
                    }
                }
            }
        }
    }
}