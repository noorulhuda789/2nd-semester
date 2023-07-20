using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace PacmanGUI.GL
{
    public class Game
    {
        public static GameObject getBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, PacmanGUI.Properties.Resources.simplebox);
            return blankGameObject;
        }
        public static Image getGameObjectImage(char displayCharacter)
        {
            Image img = PacmanGUI.Properties.Resources.simplebox;
            if (displayCharacter == '|' || displayCharacter == '%')
            {
                img = PacmanGUI.Properties.Resources.vertical;
            }

            if (displayCharacter == '#')
            {
                img = PacmanGUI.Properties.Resources.horizontal;
            }

            if (displayCharacter == '.')
            {
                img = PacmanGUI.Properties.Resources.pallet;
            }
            if (displayCharacter == 'P' || displayCharacter == 'p')
            {
                img = PacmanGUI.Properties.Resources.pacman_open;
            }
            if (displayCharacter == 'H' || displayCharacter == 'h')
            {
                img = PacmanGUI.Properties.Resources.ghost_pink;
            }
            if (displayCharacter == 'V' || displayCharacter == 'v')
            {
                img = PacmanGUI.Properties.Resources.ghost_orange;
            }
            if (displayCharacter == 'S' || displayCharacter == 's')
            {
                img = PacmanGUI.Properties.Resources.ghost_red;
            }

            return img;
        }
    }
}