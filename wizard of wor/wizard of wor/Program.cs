using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EZInput;
using System.Threading;
namespace wizard_of_wor
{
    class Program
    {
        static char[,] leftbuddy = new char[,] { { ' ', ' ', ' ', '\u2580' }, { 'o', '<', '|', '\u2593' }, { ' ', '/', '\\', ' ' } };
        static char[,] rightbuddy = new char[,] { { ' ', '\u2580', ' ', ' ' }, { '\u2593', '|', '>', 'o', }, { '/', '\\', ' ', ' ' } };
        static char[,] downbuddy = new char[,] { { ' ', '\u2580', ' ', ' ' }, { '\u2593', '|', '-', ' ' }, { '/', '\\', 'o', ' ' } };
        static char[,] upbuddy = new char[,] { { ' ', '\u2580', ' ', 'o' }, { '\u2593', '|', '^', ' ' }, { '/', '\\', ' ', ' ' } };
        static char[,] enemy = new char[,] { { ' ', '-', '-', ' ' }, { '|', 'o', 'o', '|' }, { '|', '/', '\\', '|' } };

        static void Main(string[] args)
        {
            char[,] maze = new char[35, 69];
            int playerx = 5;
            int playery = 25;
            int enemyx1 = 2;
            int enemyy1 = 5;
            int enemyx2 = 2;
            int enemyy2 = 19;
            int count = 0;
            int count2 = 0;
            bool upgoing = true;
            bool upgoing2 = true;
            // bullet of hero
            int[] arrowX = new int[100];
            int[] arrowY = new int[100];
            int arrowcount = 0;
            frontpage();
            header();
            Console.Read();
            Console.Clear();
            bool left = false, right = true, up = false, down = false;
            LoadMaze(maze);
            Printmaze(maze);
            enemy1(enemyx1, enemyy1);
            printplayer(playerx, playery);
            bool reslut;
            while (true)
            {
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    reslut = serachbycoordinates(playerx - 1, playery, maze);
                    if (reslut == true)
                    {
                        eraseplayerLeft(playerx, playery, maze);
                        playerx = playerx - 1;
                        printplayerLeft(playerx, playery, maze);
                        left = true;
                        right = false;
                        up = false;
                        down = false;

                    }


                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    reslut = serachbycoordinates(playerx + 4, playery, maze);
                    if (reslut == true)

                    {
                        eraseplayerLeft(playerx, playery, maze);
                        playerx = playerx + 1;
                        printplayerRight(playerx, playery, maze);
                        left = false;
                        right = true;
                        up = false;
                        down = false;
                    }
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {

                    reslut = serachdown(playerx, playery + 3, maze);
                    if (reslut == true)
                    {

                        eraseplayerLeft(playerx, playery, maze);
                        playery = playery + 1;
                        printplayerDown(playerx, playery, maze);
                        left = false;
                        right = false;
                        up = false;
                        down = true;
                    }
                }
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    reslut = serachdown(playerx, playery - 1, maze);
                    if (reslut == true)
                    {

                        eraseplayerLeft(playerx, playery, maze);
                        playery = playery - 1;
                        printplayerUp(playerx, playery, maze);
                        left = false;
                        right = false;
                        up = true;
                        down = false;
                    }


                }
                if (Keyboard.IsKeyPressed(Key.Space))
                {
                    if (left == true)
                    {

                        Createbullet(ref arrowcount, playerx, playery, arrowX, arrowY, maze);
                    }
                    if (right == true)
                    {
                        CreatebulletRight(ref arrowcount, playerx + 4, playery, arrowX, arrowY, maze);

                    }
                    if (up == true)
                    {

                        Createbullet(ref arrowcount, playerx - 1, playery, arrowX, arrowY, maze);

                    }
                    if (down == true)
                    {

                        Createbullet(ref arrowcount, playerx - 1, playery, arrowX, arrowY, maze);

                    }
                }

                MoveArrow(ref arrowcount, arrowX, arrowY, maze);

                enemymove(ref enemyx1, ref enemyy1, maze, ref count, ref upgoing);
                enemymove2(ref enemyx2, ref enemyy2, maze, ref count2, ref upgoing2);
                Thread.Sleep(100);
            }


            Console.ReadKey();
        }

        static void LoadMaze(char[,] maze)
        {
            int row = 0, col = 0;
            string path = "C:\\Users\\hp\\Documents\\2nd semester\\opp and pd\\maze.txt";
            char buffer;
            StreamReader fileVariable = new StreamReader(path);
            do
            {
                buffer = (char)fileVariable.Read();
                if (buffer == '\r') continue;
                if (buffer == '\n')
                {
                    row++;
                    col = 0;
                }
                else
                {
                    maze[row, col] = buffer;

                    col++;
                }
            } while (!fileVariable.EndOfStream);
            fileVariable.Close();


        }

        static void Printmaze(char[,] maze)
        {
            for (int i = 0; i < 35; i++)
            {
                for (int j = 0; j < 69; j++)
                {
                    Console.Write(maze[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void printplayer(int playerx, int playery)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < 3; i++)
            {

                Console.SetCursorPosition(playerx + i, playery + i);

                for (int j = 0; j < 4; j++)
                {
                    Console.Write(rightbuddy[i, j]);

                }

            }
        }
        static void printplayerLeft(int playerx, int playery, char[,] maze)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < 3; i++)
            {

                Console.SetCursorPosition(playerx + i, playery + i);

                for (int j = 0; j < 4; j++)
                {
                    Console.Write(leftbuddy[i, j]);

                }

            }

        }

        static void eraseplayerLeft(int playerx, int playery, char[,] maze)
        {

            if (maze[playery, playerx - 1] != '#')
            {

                for (int i = 0; i < 3; i++)
                {

                    Console.SetCursorPosition(playerx + i, playery + i);

                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(" ");

                    }

                }

            }


        }



        static void printplayerRight(int playerx, int playery, char[,] maze)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            for (int i = 0; i < 3; i++)
            {

                Console.SetCursorPosition(playerx, playery + i);

                for (int j = 0; j < 4; j++)
                {
                    Console.Write(rightbuddy[i, j]);
                }

            }

        }
        static void printplayerDown(int playerx, int playery, char[,] maze)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            for (int i = 0; i < 3; i++)
            {

                Console.SetCursorPosition(playerx, playery + i);

                for (int j = 0; j < 4; j++)
                {
                    Console.Write(downbuddy[i, j]);
                }

            }

        }
        static void printplayerUp(int playerx, int playery, char[,] maze)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < 3; i++)
            {

                Console.SetCursorPosition(playerx, playery + i);

                for (int j = 0; j < 4; j++)
                {
                    Console.Write(upbuddy[i, j]);
                }

            }

        }
        static bool serachbycoordinates(int k, int m, char[,] maze)
        {
            bool reslut = true;
            for (int i = 0; i < 3; i++)
            {

                if (maze[m + i, k] == '#')
                {
                    reslut = false;
                    break;
                }

            }
            return reslut;
        }
        static bool serachdown(int k, int m, char[,] maze)
        {
            bool reslut = true;
            for (int i = 0; i < 4; i++)
            {

                if (maze[m, k + i] == '#')
                {
                    reslut = false;
                    break;
                }

            }
            return reslut;
        }

        static void Createbullet(ref int arrowCount, int heroX, int heroY, int[] arrowX, int[] arrowY, char[,] maze)
        {

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            arrowX[arrowCount] = heroX;
            arrowY[arrowCount] = heroY + 1;
            if (maze[arrowY[arrowCount], arrowX[arrowCount]] == ' ')
            {

                Console.SetCursorPosition(heroX, heroY + 1);
                Console.Write("o");
                arrowCount++;
            }
        }
        static void MoveArrow(ref int arrowCount, int[] arrowX, int[] arrowY, char[,] maze)
        {
            for (int x = 0; x < arrowCount; x++)
            {
                char next = maze[arrowY[x], arrowX[x] - 1];
                if (next != ' ')
                {
                    EraseArrow(arrowX[x], arrowY[x], maze);
                    MakeArrowInActive(x, ref arrowCount, arrowX, arrowY);
                }
                else
                {
                    EraseArrow(arrowX[x], arrowY[x], maze);

                    arrowX[x] = arrowX[x] - 1;

                    PrintArrow(arrowX[x], arrowY[x], maze);
                }
            }
        }


        // right bullet
        static void CreatebulletRight(ref int arrowCount, int heroX, int heroY, int[] arrowX, int[] arrowY, char[,] maze)
        {

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            arrowX[arrowCount] = heroX;
            arrowY[arrowCount] = heroY + 1;
            if (maze[arrowY[arrowCount], arrowX[arrowCount]] == ' ')
            {

                Console.SetCursorPosition(heroX, heroY + 1);
                Console.Write("o");
                arrowCount++;
            }
        }
        static void PrintArrow(int x, int y, char[,] maze)
        {

            Console.SetCursorPosition(x, y);
            Console.Write("o");
        }

        static void EraseArrow(int x, int y, char[,] maze)
        {

            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }

        static void MakeArrowInActive(int index, ref int arrowCount, int[] arrowX, int[] arrowY)
        {
            for (int x = index; x < arrowCount; x++)
            {
                arrowX[x] = arrowX[x + 1];
                arrowY[x] = arrowY[x + 1];
            }
            arrowCount--;
        }
        static void enemy1(int enemyx1, int enemyy1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < enemy.GetLength(0); i++)

            {

                Console.SetCursorPosition(enemyx1, enemyy1 + i);
                for (int j = 0; j < enemy.GetLength(1); j++)
                {
                    Console.Write(enemy[i, j]);
                }
                Console.WriteLine();
            }

        }
        static void enemy2(int enemyx1, int enemyy1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < enemy.GetLength(0); i++)

            {

                Console.SetCursorPosition(enemyx1, enemyy1 + i);
                for (int j = 0; j < enemy.GetLength(1); j++)
                {
                    Console.Write(enemy[i, j]);
                }
                Console.WriteLine();
            }

        }
        static void enemy1erase(int enemyx2, int enemyy2)
        {

            for (int i = 0; i < enemy.GetLength(0); i++)

            {
                Console.SetCursorPosition(enemyx2, enemyy2 + i);
                for (int j = 0; j < enemy.GetLength(1); j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
        static void enemymove(ref int enemyx, ref int enemyy, char[,] maze, ref int count, ref bool upgoing)
        {


            if (count % 2 == 0 || count == 0)
            {
                upgoing = false;
            }
            else
            {
                upgoing = true;
            }

            if (upgoing == false)
            {
                if (maze[enemyy + 1, enemyx] == ' ')
                {
                    enemy1erase(enemyx, enemyy);
                    enemyy = enemyy + 1;
                    enemy1(enemyx, enemyy);


                }
                if (maze[enemyy + 4, enemyx] == '#')
                {
                    enemy1erase(enemyx, enemyy);

                    count = count + 1;
                }

            }
            else
            {
                if (maze[enemyy - 1, enemyx] != '#')
                {
                    enemy1erase(enemyx, enemyy);
                    enemyy = enemyy - 1;
                    enemy1(enemyx, enemyy);

                }
                if (maze[enemyy - 2, enemyx] == '#')
                {
                    enemy1erase(enemyx, enemyy);
                    count = count + 1;
                }

            }


        }
        static void enemymove2(ref int enemyx, ref int enemyy, char[,] maze, ref int count, ref bool upgoing)
        {


            if (count % 2 == 0 || count == 0)
            {
                upgoing = false;
            }
            else
            {
                upgoing = true;
            }

            if (upgoing == false)
            {
                if (maze[enemyy, enemyx + 1] == ' ')
                {
                    enemy1erase(enemyx, enemyy);
                    enemyx = enemyx + 1;
                    enemy2(enemyx, enemyy);


                }
                if (maze[enemyy, enemyx + 4] == '#')
                {
                    enemy1erase(enemyx, enemyy);

                    count = count + 1;
                }

            }
            else
            {
                if (maze[enemyy, enemyx - 2] != '#')
                {
                    enemy1erase(enemyx, enemyy);
                    enemyx = enemyx - 1;
                    enemy2(enemyx, enemyy);

                }
                if (maze[enemyy, enemyx - 2] == '#')
                {
                    enemy1erase(enemyx, enemyy);
                    count = count + 1;
                }

            }


        }

        static void frontpage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                       .'* *.'                    ");
            Console.WriteLine("                    __/_*_*(_                      ");
            Console.WriteLine("                   / _______ \\                      ");
            Console.WriteLine("                 _\\_)/___\\(_/_                      ");
            Console.WriteLine("                 / _((\\- -/))_ \\                     ");
            Console.WriteLine("                \\ \\())(-)(()/ /         ");
            Console.WriteLine("                  ' \\(((()))/ '         ");
            Console.WriteLine("                 / ' \\)).))/ ' \\         ");
            Console.WriteLine("                / _ \\ - | - /_  \\                    ");
            Console.WriteLine("               (   ( .;''';. .'  )                    ");
            Console.WriteLine("               _\"__ /    )\\ __ / _                   ");
            Console.WriteLine("                \\/  \\   ' /  \\/                       ");
            Console.WriteLine("                  .'  '...' ' )         ");
            Console.WriteLine("                   / /  |  \\ \\           ");
            Console.WriteLine("                  / .   .   . \\             ");
            Console.WriteLine("                 /   .     .   \\             ");
            Console.WriteLine("                /   /   |   \\   \\           ");
            Console.WriteLine("              .'   /    b    '.  '. ");
            Console.WriteLine("          _.-'    /     Bb     '-. '-._  ");
            Console.WriteLine("      _.-'       |      BBb       '-.  '-.");
            Console.WriteLine("     (________mrf\\____.dBBBb.________)____)");
        }
        static void header()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(50, 7);
            Console.WriteLine("   __          ___                  _  ");
            Console.SetCursorPosition(50, 8);
            Console.WriteLine("   \\ \\         / (_)               | | ");
            Console.SetCursorPosition(50, 9);
            Console.WriteLine("    \\ \\  /\\  / / _ ______ _ _ __ __| | ");
            Console.SetCursorPosition(50, 10);
            Console.WriteLine("     \\ \\/  \\/ / | |_  / _` | '__/ _` | ");
            Console.SetCursorPosition(50, 11);

            Console.WriteLine("      \\  /\\  /  | |/ / (_| | | | (_| | ");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("       \\/  \\/   |_/___\\__,_|_|  \\__,_| ");

            Console.WriteLine();
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("                   __               ");
            Console.SetCursorPosition(50, 15);

            Console.WriteLine("                  / _|               ");
            Console.SetCursorPosition(50, 16);
            Console.WriteLine("              ___ | |_                ");
            Console.SetCursorPosition(50, 17);
            Console.WriteLine("             / _ \\|  _|              ");
            Console.SetCursorPosition(50, 18);
            Console.WriteLine("             | (_)| |               ");
            Console.SetCursorPosition(50, 19);
            Console.WriteLine("             \\___/|_|               ");
            Console.WriteLine();
            Console.SetCursorPosition(50, 21);
            Console.WriteLine("         __          __                     ");
            Console.SetCursorPosition(50, 22);
            Console.WriteLine("        \\ \\        / /                     ");
            Console.SetCursorPosition(50, 23);
            Console.WriteLine("         \\ \\  /\\  / /__  _ __              ");
            Console.SetCursorPosition(50, 24);
            Console.WriteLine("          \\ \\/  \\/ / _ \\| '__|             ");
            Console.SetCursorPosition(50, 25);
            Console.WriteLine("           \\  /\\  / (_) | |                ");
            Console.SetCursorPosition(50, 26);
            Console.WriteLine("            \\/  \\/ \\___/|_|                ");
        }
    }
}




