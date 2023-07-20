using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PacmanGUI.GL
{
    public class Pacman : GameObject
    {
        
        public Pacman(Image image, GameCell startCell) : base(GameObjectType.PLAYER, image)
        {
            this.CurrentCell = startCell;
        }
        public GameCell move(GameDirection direction)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            this.CurrentCell = nextCell;
            if (currentCell != nextCell)
            {
                this.image = Properties.Resources.pacman_close;
                currentCell.setGameObject(Game.getBlankGameObject());
                this.image = Properties.Resources.pacman_open;

            }
            return nextCell;
        }
        public static Pacman currentcell()
        {
            return CurrentCell;
        }

    }


}