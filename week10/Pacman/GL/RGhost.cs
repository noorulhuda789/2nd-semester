using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    class RGhost:Ghost
    {
        public RGhost(GameObjectType gameObjectType, char displayCharacter) : base(gameObjectType, displayCharacter)
        { }
        public RGhost(GameCell cell, char displayCharacter) : base(cell, displayCharacter)
        { }
        public override void Move(ref ObjectDirection direction)
        {
            ObjectDirection[] Select = new ObjectDirection[] { ObjectDirection.DOWN, ObjectDirection.UP, ObjectDirection.RIGHT,ObjectDirection.LEFT };
            Random number = new Random();
            int i = number.Next(4);
            direction = Select[i];
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
