using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    abstract class Ghost:GameObject
    {
        public Ghost(GameObjectType gameObjectType, char displayCharacter) : base(gameObjectType, displayCharacter)
        { }
        public Ghost(GameCell cell, char displayCharacter) : base(cell, displayCharacter)
        { }
        public abstract void Move(ref ObjectDirection direction);
     

    }
}
