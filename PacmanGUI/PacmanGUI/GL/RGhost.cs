using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGUI.GL
{
    class RGhost : Ghost
    {
        public RGhost(Image image, GameCell startCell) : base(image, startCell)
        {
        }

        public override GameCell move()
        {
            throw new NotImplementedException();
        }
    }
}
