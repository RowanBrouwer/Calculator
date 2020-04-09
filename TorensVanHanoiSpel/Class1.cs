using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorensVanHanoiSpel
{
    class Piece
    {
        public Point locat;
        Control control;
        public int width;
        public bool toren2 = false;
        public bool toren3 = false;
        public bool toren1 = false;

        public Piece(Control controls, Color color, int x, Point location)
        {
            width = x;
            controls.Width = x;
            controls.BackColor = color;
            controls.Location = location;
            control = controls;
            toren1 = true;
        }

        public void Select(MouseEventArgs button)
        {
            if (button.Button == MouseButtons.Left)
                control.Select();
        }

        public void Move(Point p)
        {
            control.Location = p;
            p = locat;
        }
    }
}
