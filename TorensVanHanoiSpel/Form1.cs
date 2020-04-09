using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorensVanHanoiSpel
{
    public partial class Form1 : Form
    {
        Piece[] p = new Piece[12];
        Random ran = new Random();
        PictureBox[] pieces = new PictureBox[12];
        Color[] colors = { Color.Orange, Color.YellowGreen, Color.Blue, Color.Red, Color.Green, Color.Cyan, Color.Pink, Color.Indigo, Color.RoyalBlue, Color.DeepSkyBlue, Color.Crimson, Color.Purple };
        int i = 0;
        Point locatie;
        int toren2cons = 0;
        int toren1cons = 0;
        int toren3cons = 0;


        public Form1()
        {
            InitializeComponent();
            pieces[0] = piece1;
            pieces[1] = piece2;
            pieces[2] = piece3;
            pieces[3] = piece4;
            pieces[4] = piece5;
            pieces[5] = piece6;
            pieces[6] = piece7;
            pieces[7] = piece8;
            pieces[8] = piece9;
            pieces[9] = piece10;
            pieces[10] = piece11;
            pieces[11] = piece12;
            toren1Stick.SendToBack();
            toren2Stick.SendToBack();
            toren3Stick.SendToBack();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = ran.Next(3, 12);
            int y = 170;
            locatie = new Point();
            locatie.X = 375;
            locatie.Y = 225;
            toren1cons = x;
            for (int i = 0; i < x; i++)
            {
                p[i] = new Piece(pieces[i], colors[i], y -= 10, locatie);
                locatie.Y = locatie.Y - 13;
                locatie.X = 460 - (pieces[i].Width / 2);
            }
        }
        private void toren3Stick_MouseClick(object sender, MouseEventArgs e)
        {
            locatie = new Point();
            locatie = toren3Stick.Location;
            locatie.Y = 225;
            locatie.X = (locatie.X + (toren3Stick.Width / 2)) - (p[i].width / 2);
            if (toren3cons == 0)
            {
                locatie.Y = 225;
                p[i].Move(locatie);
                ++toren3cons;
            }
            else
                if (Locatie(locatie) == true)
            {
                locatie.Y -= toren3cons * 13;
                p[i].Move(locatie);
                ++toren3cons;
            }
        }

        private void toren2Stick_MouseClick(object sender, MouseEventArgs e)
        {
            locatie = new Point();
            locatie = toren2Stick.Location;
            locatie.Y = 225;
            locatie.X = (locatie.X + (toren2Stick.Width / 2)) - (p[i].width / 2);
            if (toren2cons == 0)
            {
                locatie.Y = 225;
                p[i].Move(locatie);
                ++toren2cons;
            }
            else
                if (Locatie(locatie) == true)
            {
                locatie.Y -= toren2cons * 13;
                p[i].Move(locatie);
                ++toren2cons;
            }
        }
        private void toren1Stick_MouseClick(object sender, MouseEventArgs e)
        {
            locatie = new Point();
            locatie = toren1Stick.Location;
            locatie.Y = 225;
            locatie.X = (locatie.X + (toren1Stick.Width / 2)) - (p[i].width / 2);
            if (toren1cons == 0)
            {
                locatie.Y = 225;
                p[i].Move(locatie);
                ++toren1cons;
            }
            else
                if (Locatie(locatie) == true)
            {
                locatie.Y -= toren1cons * 13;
                p[i].Move(locatie);
                ++toren1cons;
            }
        }
        bool Locatie(Point lo)
        {
            p[i].locat = lo;
            for (int r = 0; r < 12; r++)
                if ((p[i].locat.X / 2) == (p[r].locat.X / 2))
                    if (p[i].width > p[r].width)
                        return false;
                    else
                        return true;
                else
                    return true;
            return false;
        }


    private void piece1_MouseClick(object sender, MouseEventArgs e)
        {
            p[0].Select(e);
            i = 0;
        }

        private void piece2_MouseClick(object sender, MouseEventArgs e)
        {
            p[1].Select(e);
            i = 1;
        }

        private void piece3_MouseClick(object sender, MouseEventArgs e)
        {
            p[2].Select(e);
            i = 2;
        }

        private void piece4_MouseClick(object sender, MouseEventArgs e)
        {
            p[3].Select(e);
            i = 3;
        }

        private void piece5_MouseClick(object sender, MouseEventArgs e)
        {
            p[4].Select(e);
            i = 4;
        }

        private void piece6_MouseClick(object sender, MouseEventArgs e)
        {
            p[5].Select(e);
            i = 5;
        }

        private void piece7_MouseClick(object sender, MouseEventArgs e)
        {
            p[6].Select(e);
            i = 6;
        }

        private void piece8_MouseClick(object sender, MouseEventArgs e)
        {
            p[7].Select(e);
            i = 7;
        }
        private void piece9_MouseClick(object sender, MouseEventArgs e)
        {
            p[8].Select(e);
            i = 8;
        }
        private void piece10_MouseClick(object sender, MouseEventArgs e)
        {
            p[9].Select(e);
            i = 9;
        }
        private void piece11_MouseClick(object sender, MouseEventArgs e)
        {
            p[10].Select(e);
            i = 10;
        }
        private void piece12_MouseClick(object sender, MouseEventArgs e)
        {
            p[11].Select(e);
            i = 11;
        }
    }
}
