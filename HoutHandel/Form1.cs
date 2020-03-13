using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoutHandel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Berekenen()
        {
            string am3 = aantalm3.Text;
            string pd = plaatdikte.Text;
            double m3 = 0;
            double pd2 = 0;
            double m2 = 0;
            double price = 0;
            try
            {
                double.TryParse(am3, out m3);
                double.TryParse(pd, out pd2);
            }
            catch (FormatException)
            {
                uitkomst.Text = "";
            }
            catch (OverflowException)
            {
                throw;
            }
            double mtocm = pd2 / 100;
            m2 = m3 / mtocm;
            double schaafkost = m2 * 0.60;

            if (meerdan14.Checked == true)
            {

                if (klas1.Checked == true)
                {
                    price = 300;;
                    double total = (m3 * price) + schaafkost;
                    if (total > 200)
                    {
                        uitkomst.Text = (((total - schaafkost) / 100) * 99).ToString("€ ##.##");
                    }
                    else if (total < 200)
                    {
                        double calcwschaaf = ((total  / 100) * 99);
                        uitkomst.Text = calcwschaaf.ToString("€ ##.##");
                        
                    }
                }
                else if (klas2.Checked == true)
                {
                    price = 500;
                    double total = (m3 * price) + schaafkost;
                    if (total > 200)
                    {
                        uitkomst.Text = (((total - schaafkost) / 100) * 99).ToString("€ ##.##");
                    }
                    else if (total < 200)
                    {
                        double calcwschaaf = ((total / 100) * 99);
                        uitkomst.Text = calcwschaaf.ToString("€ ##.##");
                    }
                }
                else if (klas3.Checked == true)
                {
                    price = 450;
                    double total = (m3 * price) + schaafkost;
                    if (total > 200)
                    {
                        uitkomst.Text = (((total - schaafkost) / 100) * 99).ToString("€ ##.##");
                    }
                    else if (total < 200)
                    {
                        double calcwschaaf = ((total / 100) * 99);
                        uitkomst.Text = calcwschaaf.ToString("€ ##.##");
                    }
                }
                else if (klas1.Checked == false && klas2.Checked == false && klas3.Checked == false)
                {
                    uitkomst.Text = "kies je hout klasse";
                }
            }
            else if (meerdan21.Checked == true)
            {
                if (klas1.Checked == true)
                {
                    price = 300; ;
                    double total = (m3 * price) + schaafkost;
                    if (total > 200)
                    {
                        uitkomst.Text = (((total - schaafkost) / 100) * 98).ToString("€ ##.##");
                    }
                    else if (total < 200)
                    {
                        double calcwschaaf = ((total / 100) * 98);
                        uitkomst.Text = calcwschaaf.ToString("€ ##.##");
                    }
                }
                else if (klas2.Checked == true)
                {
                    price = 500;
                    double total = (m3 * price) + schaafkost;
                    if (total > 200)
                    {
                        uitkomst.Text = (((total - schaafkost) / 100) * 98).ToString("€ ##.##");
                    }
                    else if (total < 200)
                    {
                        double calcwschaaf = ((total / 100) * 98);
                        uitkomst.Text = calcwschaaf.ToString("€ ##.##");
                    }
                }
                else if (klas3.Checked == true)
                {
                    price = 450;
                    double total = (m3 * price) + schaafkost;
                    if (total > 200)
                    {
                        uitkomst.Text = (((total - schaafkost) / 100) * 98).ToString("€ ##.##");
                    }
                    else if (total < 200)
                    {
                        double calcwschaaf = ((total / 100) * 98);
                        uitkomst.Text = calcwschaaf.ToString("€ ##.##");
                    }
                }
                else if (klas1.Checked == false && klas2.Checked == false && klas3.Checked == false)
                {
                    uitkomst.Text = "kies je hout klasse";
                }
            }
            else if (meerdan28.Checked == true)
            {
                if (klas1.Checked == true)
                {
                    price = 300; ;
                    double total = (m3 * price) + schaafkost;
                    if (total > 200)
                    {
                        uitkomst.Text = (((total - schaafkost) / 100) * 97.5).ToString("€ ##.##");
                    }
                    else if (total < 200)
                    {
                        double calcwschaaf = ((total / 100) * 97.5);
                        uitkomst.Text = calcwschaaf.ToString("€ ##.##");
                    }
                }
                else if (klas2.Checked == true)
                {
                    price = 500;
                    double total = (m3 * price) + schaafkost;
                    if (total > 200)
                    {
                        uitkomst.Text = (((total - schaafkost) / 100) * 97.5).ToString("€ ##.##");
                    }
                    else if (total < 200)
                    {
                        double calcwschaaf = ((total / 100) * 97.5);
                        uitkomst.Text = calcwschaaf.ToString("€ ##.##");
                    }
                }
                else if (klas3.Checked == true)
                {
                    price = 450;
                    double total = (m3 * price) + schaafkost;
                    if (total > 200)
                    {
                        uitkomst.Text = (((total - schaafkost) / 100) * 97.5).ToString("€ ##.##");
                    }
                    else if (total < 200)
                    {
                        double calcwschaaf = ((total / 100) * 97.5);
                        uitkomst.Text = calcwschaaf.ToString("€ ##.##");
                    }
                }
                else if (klas1.Checked == false && klas2.Checked == false && klas3.Checked == false)
                {
                    uitkomst.Text = "kies je hout klasse";
                }
            }
            else if (meerdan14.Checked == false && meerdan21.Checked == false && meerdan28.Checked == false)
            {
                uitkomst.Text = "kies je levertijd";
            }
        }

        private void Bereken_Click(object sender, EventArgs e)
        {
            Berekenen();
        }

        private void meerdan14_CheckedChanged(object sender, EventArgs e)
        {
            meerdan21.Checked = false;
            meerdan28.Checked = false;
        }

        private void meerdan21_CheckedChanged(object sender, EventArgs e)
        {
            meerdan14.Checked = false;
            meerdan28.Checked = false;
        }

        private void meerdan28_CheckedChanged(object sender, EventArgs e)
        {
            meerdan14.Checked = false;
            meerdan21.Checked = false;
        }

        private void klas1_CheckedChanged(object sender, EventArgs e)
        {
            klas2.Checked = false;
            klas3.Checked = false;
        }

        private void klas2_CheckedChanged(object sender, EventArgs e)
        {
            klas1.Checked = false;
            klas3.Checked = false;
        }

        private void klas3_CheckedChanged(object sender, EventArgs e)
        {
            klas1.Checked = false;
            klas2.Checked = false;
        }
    }
}
