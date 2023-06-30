using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    class VGhost : Ghost
    {
        public VGhost(GameObjectType gameObjectType, char displayCharacter) : base(gameObjectType, displayCharacter)
        { }
        public VGhost(GameCell cell, char displayCharacter) : base(cell, displayCharacter)
        { }
        public override void Move(ref ObjectDirection direction)
        {
            if (direction == ObjectDirection.UP)
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
                    direction = ObjectDirection.DOWN;
                }
            }
            if (direction == ObjectDirection.DOWN)
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
                    direction = ObjectDirection.UP;
                }
            }
        }
    }
}

