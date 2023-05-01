using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;
using System.IO;
using System.Threading;
using game.river_raid;
namespace game
{
    class Program
    {
        public int enemyX;


        // Player Bullets
        static int[] bulletX = new int[100];
        static int[] bulletY = new int[100];
        static bool[] isBulletActive = new bool[100];
        // static string[] maze = new string[62];
        static char[,] maze = new char[44, 90];
        static string[] hero1 = new string[] { "_", "_", "|", "_", "_" };
        static string[] hero2 = new string[] { "-", "-", "o", "-", "-", "(", "_", ")", "-", "-", "o", "-", "-" };
        static int count = 0;
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
            int score = 2;
            int health = 100;
            int heroX = 20;
            int heroY = 40;
            int herox = 20;
            int heroy = 20;
            Game s = new Game(score, health, heroX, heroY, herox, heroy);
            printmaze();
            printhero(s);
            int enemyY = s.heroY / 2;
            int enemyX = s.heroX;

            while (true)
            {
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    addscoreerase(s);
                    moveheroUp(s);

                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    addscoreerase(s);
                    moveheroDown(s);
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {

                    moveheroLeft(s);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    moveheroRight(s);
                }
                if (Keyboard.IsKeyPressed(Key.Space))
                {
                    generateBullet(s);
                }
                moveBullet(s);

                enemy(s);
                moveBulletofenemy(s, enemyX, enemyY);
                generateBulletenemy(s, enemyX, enemyY);
                printBulletofenemy(s.heroX, s.heroY);
                addscore(s);
                collision(s, enemyX, enemyY);

                PrintRandomly(s);
                Thread.Sleep(500);

            }

        }

        static void printhero(Game s)
        {

            Console.SetCursorPosition(s.heroX, s.heroY);
            for (int i = 0; i < hero1.Length; i++)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(hero1[i]);
            }


            Console.SetCursorPosition(s.heroX - 4, s.heroY + 1);
            for (int i = 0; i < hero2.Length; i++)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(hero2[i]);
            }
        }
        static void erasehero(Game s)
        {

            Console.SetCursorPosition(s.heroX, s.heroY);
            for (int i = 0; i < hero1.Length; i++)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("  ");
            }

            Console.WriteLine();
            Console.SetCursorPosition(s.heroX - 4, s.heroY + 1);
            for (int i = 0; i < hero2.Length; i++)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("  ");
            }
        }

        static void moveheroUp(Game s)
        {

            if (maze[s.heroY - 1, s.heroX] == ' ')
            {
                erasehero(s);

                s.heroY = s.heroY - 1;
                printhero(s);
            }
        }
        static void moveheroLeft(Game s)
        {

            if (maze[s.heroY, s.heroX - 1] == ' ')
            {
                erasehero(s);
                s.heroX = s.heroX - 1;

                printhero(s);
            }

        }
        static void moveheroRight(Game s)
        {


            if (maze[s.heroY, s.heroX + 1] == ' ')
            {
                erasehero(s);
                s.heroX = s.heroX + 1;

                printhero(s);

            }

        }
        static void moveheroDown(Game s)
        {


            if (maze[s.heroY + 1, s.heroX] == ' ')
            {
                erasehero(s);
                s.heroY = s.heroY + 1;

                printhero(s);
            }

        }
        static void generateBullet(Game s)
        {

            bulletX[s.bulletcount] = s.heroX + 3;
            bulletY[s.bulletcount] = s.heroY - 1;
            isBulletActive[s.bulletcount] = true;
            Console.SetCursorPosition(s.heroX + 3, s.heroY - 1);
            Console.Write(".");
            s.bulletcount++;
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

        static void moveBullet(Game s)
        {
            for (int x = 0; x < s.bulletcount; x++)
            {
                if (isBulletActive[x] == true)
                {
                    if (maze[bulletY[x] - 1, bulletX[x]] == ' ')
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
                    if (bulletY[x] == 0)
                    {
                        eraseBullet(bulletX[x], bulletY[x]);
                        makeBulletInactive();
                    }
                }
            }
        }
        static void enemy(Game s)
        {


            char fullBlock = '\u2588';
            Console.SetCursorPosition(20, 20);
            Console.Write(fullBlock);
            Console.SetCursorPosition(21, 20);
            Console.Write(fullBlock);

        }
        static void generateBulletenemy(Game s, int enemyX, int enemyY)
        {



            s.bulletenmeyX = enemyX;
            s.bulletenemyY = enemyY + 1;
            Console.SetCursorPosition(s.herox, (s.heroy) + 1);
            Console.Write("*");
            Console.SetCursorPosition(s.herox, (s.heroy) - 1);
            Console.Write("*");
            Console.SetCursorPosition(s.herox + 2, s.heroy);
            Console.Write("*");
            Console.SetCursorPosition(s.herox - 1, s.heroy);
            Console.Write("*");
            count++;

        }
        static void moveBulletofenemy(Game s, int enemyX, int enemyY)
        {

            for (int x = 0; x < count; x++)
            {
                if (maze[enemyX, enemyY + 1] == ' ')
                {

                    eraseBulletofenemy(s.bulletenmeyX, s.bulletenemyY);

                    s.bulletenemyY = s.bulletenemyY + 1;
                    printBulletofenemy(s.bulletenmeyX, s.bulletenemyY);
                }
                else
                {
                    eraseBullet(s.bulletenmeyX, s.bulletenemyY);

                }
                if (s.bulletenemyY == s.heroY)
                {
                    eraseBullet(s.bulletenmeyX, s.bulletenemyY);
                    break;

                }
            }
        }
        static void PrintRandomly(Game s)
        {

            Random random = new Random();

            int minRow = s.heroX;
            int maxRow = s.heroY - 1;

            int row = random.Next(minRow, maxRow + 1);

            if (random.Next(2) == 0)
            {
                Console.SetCursorPosition(5, row);
                Console.Write("*");
            }

        }
        static void eraseBulletofenemy(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");

        }
        static void printBulletofenemy(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("*");
        }
        static void addscore(Game s)
        {

            int total = 0;
            total = s.score + total;
            Console.SetCursorPosition(60, s.heroY + 2);
            Console.Write("Score/Health");
            Console.SetCursorPosition(60, s.heroY);
            Console.Write("Score:" + total);
        }
        static void collision(Game s, int enemyX, int enemyY)
        {

            if (s.bulltmovey == 20 || s.bulltmovex == 20)
            {

                s.score = s.score + 5;
                addscore(s);
            }
        }
        static void addscoreerase(Game s)
        {

            Console.SetCursorPosition(60, s.heroY + 2);
            Console.Write("            ");
            Console.SetCursorPosition(60, s.heroY);
            Console.Write("               ");
            Console.Write("               ");
        }

    }
}



