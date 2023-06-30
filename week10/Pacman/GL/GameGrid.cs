using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pacman.GL
{
    public class GameGrid
    {
        private int rows;
        private int columns;
        private GameCell[,] grid;

        public int Rows { get => rows; set => rows = value; }
        public int Columns { get => columns; set => columns = value; }
        public GameCell[,] Grid { get => grid; set => grid = value; }

        public GameGrid(string FileName, int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
            this.Grid = new GameCell[Rows, Columns];
            LoadGrid(FileName);
        }

        private void LoadGrid(string FileName)
        {
            string path = FileName;
            if (File.Exists(path))
            {
                string line;
                StreamReader stage = new StreamReader(path);
                for (int row = 0; row < this.Rows; row++)
                {
                    line = stage.ReadLine();
                    for (int col = 0; col < this.Columns; col++)
                    {
                        GameCell cell = new GameCell(row, col, this);
                        Char tempChar = line[col];
                        GameObjectType type = GameObject.GetGameObjecttype(tempChar);
                        GameObject gameObject = new GameObject(type, tempChar);
                        cell.CurrentGameObject = gameObject;
                        Grid[row, col] = cell;

                    }
                }
                stage.Close();

            }


        }
        public GameCell GetCell(int row, int col)
        {
            return Grid[row, col];
        }

    }
}
