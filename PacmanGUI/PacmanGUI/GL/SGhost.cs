using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace PacmanGUI.GL
{
    class SGhost : Ghost
    {
        GameDirection direction = GameDirection.Right;
        public SGhost(Image image, GameCell startCell) : base(image, startCell)
        {
        }
        public void SetDirection(int x, int y)
        {
            if (x > CurrentCell.X)
            {
                direction = GameDirection.Right;
                this.Move(ref direction);
            }
            else if (y > CurrentCell.Y)
            {
                direction = GameDirection.Down;
                this.Move(ref direction);
            }
            else if (x < CurrentCell.X)
            {
                direction = GameDirection.Left;
                this.Move(ref direction);
            }
            else if (y < CurrentCell.Y)
            {
                direction = GameDirection.Up;
                this.move(ref direction);
            }
        }
        public override GameCell move()
        {
            if (Pacman.CurrentCell > CurrentCell.X)
            {
                direction = GameDirection.Right;

            }
    }
}
