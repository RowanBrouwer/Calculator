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
        private void bereken()
        {

            var i1 = m1.Text;
            var i2 = m2.Text;
            var i3 = m3.Text;
            var i4 = m4.Text;
            var i5 = m5.Text;
            var i6 = m6.Text;
            var i7 = m7.Text;
            var i8 = m8.Text;
            var i9 = m9.Text;
            var i10 = m10.Text;
            var i11 = m11.Text;
            var i12 = m12.Text;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            int p6 = 0;
            int p7 = 0;
            int p8 = 0;
            int p9 = 0;
            int p10 = 0;
            int p11 = 0;
            int p12 = 0;
            try
            {
                p1 = System.Convert.ToInt32(i1);
                p2 = System.Convert.ToInt32(i2);
                p3 = System.Convert.ToInt32(i3);
                p4 = System.Convert.ToInt32(i4);
                p5 = System.Convert.ToInt32(i5);
                p6 = System.Convert.ToInt32(i6);
                p7 = System.Convert.ToInt32(i7);
                p8 = System.Convert.ToInt32(i8);
                p9 = System.Convert.ToInt32(i9);
                p10 = System.Convert.ToInt32(i10);
                p11 = System.Convert.ToInt32(i11);
                p12 = System.Convert.ToInt32(i12);
            }
            catch (FormatException)
            {
                throw;
            }
            catch (OverflowException)
            {
                throw;
            }
            int V = 1000;
            double procnt = 0.0;
            int total = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12;
            procnt = total / V;
            if (total < 10000)
            {
                uitkomst.Text = "3%";
            }
            else if (total > 10000 || total < 20000)
            {
                uitkomst.Text = (procnt * 1.5).ToString("0 procent");
            }
            else if (total > 20000)
            {
                if (procnt > 50)
                {
                    uitkomst.Text = "50%";
                }
                else if (procnt < 50)
                {
                    uitkomst.Text = (procnt * 2).ToString("0 procent");
                }
            }

            }

            
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            bereken();
        }
    }
}
