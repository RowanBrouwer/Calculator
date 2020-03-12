using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verkopers_provisie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Bereken()
        {
            var p1 = 0; var k1 = m1.Text;
            var p2 = 0; var k2 = m2.Text;
            var p3 = 0; var k3 = m3.Text;
            var p4 = 0; var k4 = m4.Text;
            var p5 = 0; var k5 = m5.Text;
            var p6 = 0; var k6 = m6.Text;
            var p7 = 0; var k7 = m7.Text;
            var p8 = 0; var k8 = m8.Text;
            var p9 = 0; var k9 = m9.Text;
            var p10 = 0; var k10 = m10.Text;
            var p11 = 0; var k11 = m11.Text;
            var p12 = 0; var k12 = m12.Text;
            try
            {
                int.TryParse(k1, out p1); int.TryParse(k2, out p2);
                int.TryParse(k3, out p3); int.TryParse(k4, out p4);
                int.TryParse(k5, out p5); int.TryParse(k6, out p6);
                int.TryParse(k7, out p7); int.TryParse(k8, out p8);
                int.TryParse(k9, out p9); int.TryParse(k10, out p10);
                int.TryParse(k11, out p11); int.TryParse(k12, out p12);

            }
            catch (FormatException)
            {
                uitkomst.Text = "";
            }
            catch (OverflowException)
            {
                throw;
            }
            var V = 1000;
            var total = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12;
            var procnt = total / V;
            if (total == 0)
            {
                uitkomst.Text = "0%";
            }
            else if (total < 10000)
            {
                uitkomst.Text = "3%";
            }
            else if (total > 10000 || total < 20000)
            {
                string ant = (procnt * 1.5).ToString("00.0");
                uitkomst.Text = ant+("%");
            }
            else if (total > 20000)
            {
                if (procnt > 50)
                {
                    uitkomst.Text = "50%";
                }
                else if (procnt < 50)
                {
                    string ant = (procnt * 2).ToString("00.0");
                    uitkomst.Text = ant + ("%");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bereken();
        }
    }
}
