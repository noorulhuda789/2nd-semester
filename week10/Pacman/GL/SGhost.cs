using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    class SGhost:Ghost
    {
        public SGhost(GameObjectType gameObjectType, char displayCharacter) : base(gameObjectType, displayCharacter)
        { }
        public SGhost(GameCell cell, char displayCharacter) : base(cell, displayCharacter)
        {}
        public void SetDirection(int x, int y, ref ObjectDirection direction)
        {
            if(x> CurrentCell.X)
            {
                direction = ObjectDirection.RIGHT;
                this.Move(ref direction);
            }
            else if(y > CurrentCell.Y)
            {
                direction = ObjectDirection.DOWN;
                this.Move(ref direction);
            }
            else if(x< CurrentCell.X)
            {
                direction = ObjectDirection.LEFT;
                this.Move(ref direction);
            }
            else if(y < CurrentCell.Y)
            {
                direction = ObjectDirection.UP;
                this.Move(ref direction);
            }
        }
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
