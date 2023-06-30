using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    public class PacmanPlayer : GameObject
    {
        public PacmanPlayer(GameObjectType gameObjectType, char DisplayCharacter) : base(gameObjectType, DisplayCharacter)
        {
        }
        public PacmanPlayer(char DisplayCharacter, GameCell CurrentCell) : base(CurrentCell, DisplayCharacter)
        {
        }
        public GameCell Move(ObjectDirection direction)
        {
            return CurrentCell.NextCell(direction);
        }
    }
}
