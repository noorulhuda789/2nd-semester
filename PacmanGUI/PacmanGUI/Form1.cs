using PacmanGUI.GL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace PacmanGUI
{
    public partial class Form1 : Form
    {
        Pacman pacman;
        HGhost hGhost;
        VGhost vGhost;
        SGhost sGhost;
        string HDirection = "Left";
        string VHDirection = "Top";
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                pacman.move(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                pacman.move(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                pacman.move(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                pacman.move(GameDirection.Down);
            }
        }
        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {

                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    this.Controls.Add(cell.PictureBox);
                    //        printCell(cell);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameGrid grid = new GameGrid("maze.txt", 24, 71);
            Image pacManImage = Game.getGameObjectImage('P');
            GameCell startCell1 = grid.getCell(8, 10);
            GameCell startCell2 = grid.getCell(1, 3);
            GameCell startCell3 = grid.getCell(2, 2);
            GameCell startCell4 = grid.getCell(12, 10);
            GameCell startCell5 = grid.getCell(8, 10);
            pacman = new Pacman(pacManImage, startCell1);
            Image HGimage = Game.getGameObjectImage('H');
            hGhost = new HGhost(HGimage, startCell2);
            Image VGimage = Game.getGameObjectImage('V');
            vGhost = new VGhost(VGimage, startCell3);
            Image SGimage = Game.getGameObjectImage('S');
            sGhost = new SGhost(SGimage, startCell4);
            printMaze(grid);
        }

        private void GhostTimer_Tick(object sender, EventArgs e)
        {
            hGhost.move();
            vGhost.move();
        }
    }
}
