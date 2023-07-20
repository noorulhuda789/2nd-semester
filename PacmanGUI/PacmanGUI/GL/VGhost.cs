using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace PacmanGUI.GL
{
    class VGhost : Ghost
    {
        GameDirection direction = GameDirection.Up;
        public VGhost(Image image, GameCell startCell) : base(image, startCell)
        {
        }
        public override GameCell move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(ref direction);
            GameObject nextObject = nextCell.currentGameObject;
            this.CurrentCell = nextCell;
            if (currentCell != nextCell)
            {
                currentCell.setGameObject(Game.getBlankGameObject());
            }
            return nextCell;
        }
    }
}
