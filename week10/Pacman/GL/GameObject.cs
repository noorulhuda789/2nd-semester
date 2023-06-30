using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    public class GameObject
    {
        public char DisplayCharacter;
        public GameCell CurrentCell;
        public GameObjectType Obj;
        public GameObject(GameObjectType type, char displayCharacter)
        {
            this.DisplayCharacter = displayCharacter;
            this.Obj = GetGameObjecttype(this.DisplayCharacter);
        }
        public GameObject(GameCell CurrentCell, char displayCharacter)
        {
            this.DisplayCharacter = displayCharacter;
            this.CurrentCell = CurrentCell;
            this.Obj = GetGameObjecttype(this.DisplayCharacter);
        }
        public static GameObjectType GetGameObjecttype(char type)
        {
            if (type == '#' || type == '|' || type == '%')
            {
                return GameObjectType.WALL;
            }
            if (type == '.')
            {
                return GameObjectType.REWARD;
            }
            if (type == 'P')
            {
                return GameObjectType.PLAYER;
            }
            else return GameObjectType.NONE;
        }
    }
}
