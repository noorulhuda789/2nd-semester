using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wizard_of_wor.BL
{
    class Player
    {
        public char[,] leftbuddy = new char[,] { { ' ', ' ', ' ', '\u2580' }, { 'o', '<', '|', '\u2593' }, { ' ', '/', '\\', ' ' } };
        public char[,] rightbuddy = new char[,] { { ' ', '\u2580', ' ', ' ' }, { '\u2304', '|', '>', 'o', }, { '/', '\\', ' ', ' ' } };
        public char[,] downbuddy = new char[,] { { ' ', '\u2580', ' ', ' ' }, { '\u2593', '|', '\u02C5', ' ' }, { '/', '\\', 'o', ' ' } };
        public char[,] upbuddy = new char[,] { { ' ', '\u2580', ' ', 'o' }, { '\u2593', '|', '^', ' ' }, { '/', '\\', ' ', ' ' } };
        public int playerx = 5;
        public int playery = 25;
    }
}
