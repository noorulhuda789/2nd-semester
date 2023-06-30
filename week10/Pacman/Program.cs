using Pacman.GL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;

namespace Pacman
{
    public class Program
    {
        static void Main(string[] args)
        {
            GameGrid grid = new GameGrid("C:\\Users\\hp\\Music\\Pacman\\Maze.txt", 24, 71);
            GameCell start = new GameCell(12, 22, grid);
            GameCell startG = new GameCell(1, 2, grid);
            GameCell startV = new GameCell(2, 2, grid);
            GameCell startR = new GameCell(10, 20, grid);
            GameCell startS = new GameCell(15, 10, grid);
            PacmanPlayer pacman = new PacmanPlayer('p', start);
            HGhost g1 = new HGhost(startG, 'G');
            VGhost g2 = new VGhost(startV, 'V');
            RGhost g3 = new RGhost(startR, 'R');
            SGhost g4 = new SGhost(startS, 'S');
            ObjectDirection d = ObjectDirection.RIGHT;
            ObjectDirection d2 = ObjectDirection.RIGHT;
            ObjectDirection d1 = ObjectDirection.DOWN;
            ObjectDirection d3 = ObjectDirection.RIGHT;
            printMaze(grid);
            printGameObject(pacman);
            printGameObject(g1);
            printGameObject(g2);
            printGameObject(g3);
            printGameObject(g4);
            bool gameRunning = true;
            while (gameRunning)
            {
                Thread.Sleep(98);
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    moveGameObject(pacman, ObjectDirection.UP, ' ');
                }

                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    moveGameObject(pacman, ObjectDirection.DOWN, ' ');
                }

                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    moveGameObject(pacman, ObjectDirection.RIGHT, ' ');
                }

                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    moveGameObject(pacman, ObjectDirection.LEFT, ' ');
                }
                g1.Move(ref d);
                g2.Move(ref d1);
                g3.Move(ref d2);
                g4.SetDirection(pacman.CurrentCell.X, pacman.CurrentCell.Y, ref d3);

            }
        }
        static void clearGameCellContent(GameCell gameCell, GameObject newGameObject)
        {
            gameCell.CurrentGameObject = newGameObject;
            Console.SetCursorPosition(gameCell.X, gameCell.Y);
            Console.Write(newGameObject.DisplayCharacter);

        }
        public static void printGameObject(GameObject gameObject)
        {
            Console.SetCursorPosition(gameObject.CurrentCell.X, gameObject.CurrentCell.Y);
            Console.Write(gameObject.DisplayCharacter);

        }

        public static void moveGameObject(GameObject gameObject, ObjectDirection direction, char character)
        {
            GameCell nextCell = gameObject.CurrentCell.NextCell(direction);
            if (nextCell.CurrentGameObject.DisplayCharacter == ' ' || nextCell.CurrentGameObject.DisplayCharacter == '.')
            {
                GameObject newGO = new GameObject(GameObjectType.NONE, character);
                GameCell currentCell = gameObject.CurrentCell;
                clearGameCellContent(currentCell, newGO);
                gameObject.CurrentCell = nextCell;
                printGameObject(gameObject);
            }
        }

        static void printMaze(GameGrid grid)
        {
            for (int row = 0; row < grid.Rows; row++)
            {
                //int abc = 0;
                for (int col = 0; col < grid.Columns; col++)
                {
                    GameCell cell = grid.GetCell(row, col);
                    printCell(cell);
                }

            }
        }

        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.X, cell.Y);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }

    }
}
