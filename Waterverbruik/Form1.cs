using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterverbruik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Berekenen()
        {
            tarief1.Text = "";
            tarief2.Text = "";
            uitkomst.Text = "";
            double kub = 0;
            try
            {
                double.TryParse(kubiek.Text, out kub);
            }
            catch (FormatException)
            {
                throw;
            }
            catch (OverflowException)
            {

            }
            double tf1 = (kub * 0.25) + 100;
            double tf2 = (kub * 0.38) + 75;
            if (tf1 < tf2)
            {
                System.Convert.ToDecimal(tf1);
                System.Convert.ToDecimal(tf2);
                tarief1.Text = tf1.ToString("€ ##.##");
                tarief2.Text = tf2.ToString("€ ##.##");
                uitkomst.Text = "Tarief 1";
            }
            else if (tf1 > tf2)
            {
                System.Convert.ToDecimal(tf1);
                System.Convert.ToDecimal(tf2);
                tarief1.Text = tf1.ToString("€ ##.##");
                tarief2.Text = tf2.ToString("€ ##.##");
                uitkomst.Text = "Tarief 2";
            }

            
        }

        private void Bereken_Click(object sender, EventArgs e)
        {
            Berekenen();
        }
    }
}
