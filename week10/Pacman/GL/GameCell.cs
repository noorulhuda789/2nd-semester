using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    public class GameCell
    {
        public int X;
        public int Y;
        public GameObject CurrentGameObject;
        public GameGrid GridMaze;
        public GameCell(int row, int col, GameGrid grid)
        {
            X = col;
            Y = row;
            GridMaze = grid;
        }
        public GameCell(int row, int col)
        {
            X = col;
            Y = row;
        }

        public GameCell NextCell(ObjectDirection direction)
        {
            if (direction == ObjectDirection.UP)
            {
                
                 return GridMaze.GetCell(Y - 1, X);
                
            }
            if (direction == ObjectDirection.DOWN)
            {
                
                 return GridMaze.GetCell(Y + 1, X);
                 
            }
            if (direction == ObjectDirection.RIGHT)
            {
                
                 return GridMaze.GetCell(Y, X + 1);
                 
            }
            if (direction == ObjectDirection.LEFT)
            {
                
                  return GridMaze.GetCell(Y, X - 1);
                   
            }
            return this;
        }
    }
}
