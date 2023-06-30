using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    class HGhost : Ghost
    {
        public HGhost(GameObjectType gameObjectType, char displayCharacter) : base(gameObjectType, displayCharacter)
        { }
        public HGhost(GameCell cell, char displayCharacter) : base(cell, displayCharacter)
        {}
        public override void Move(ref ObjectDirection direction)
        {
            if (direction == ObjectDirection.LEFT)
            {
                GameCell cell = CurrentCell.NextCell(direction);
                if (cell.CurrentGameObject.DisplayCharacter == ' ' || cell.CurrentGameObject.DisplayCharacter == '.')
                {
                    if (cell.CurrentGameObject.DisplayCharacter == '.')
                    {
                        Program.moveGameObject(this, direction, '.');
                    }
                    else
                    {
                        Program.moveGameObject(this, direction, ' ');
                    }
                }
                else
                {
                    direction = ObjectDirection.RIGHT;
                }
            }
            if (direction == ObjectDirection.RIGHT)
            {
                GameCell cell = CurrentCell.NextCell(direction);
                if (cell.CurrentGameObject.DisplayCharacter == ' ' || cell.CurrentGameObject.DisplayCharacter == '.')
                {
                    if (cell.CurrentGameObject.DisplayCharacter == '.')
                    {
                        Program.moveGameObject(this, direction, '.');
                    }
                    else
                    {
                        Program.moveGameObject(this, direction, ' ');
                    }
                }
                else
                {
                    direction = ObjectDirection.LEFT;
                }
            }

        }
    }
}
