using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Pacman.BL
{
    class Grid
    {
        public char[,] maze ;
        public int rowsize;
        public int columnsize;
        public Grid(string path,int rowsize,int columnsize)
        {
            this.rowsize = rowsize;
            this.columnsize = columnsize;
            int row = 0, col = 0;
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
                    maze[rowsize, columnsize] = buffer;

                    col++;
                }
            } while (!fileVariable.EndOfStream);
            fileVariable.Close();
        }
        public Cell getcellleft(Cell c)
        {
            c.x = c.x - 1;
            return c;
        }
        public Cell getcellright(Cell c)
        {
            c.x = c.x + 1;
            return c;
        }
        public Cell getcellup(Cell c)
        {
            c.y = c.y - 1;
            return c;
        }
        public Cell getcelldown(Cell c)
        {
            c.y = c.y +1;
            return c;
        }
        public  Cell findpacman()
        {
            Pacman s = new Pacman();
        }
    }
}
