using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoVerhuur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Berekenen()
        {
            uitkomst.Text = "";
            DateTime vertrek = dateTimePicker1.Value.Date;
            DateTime aankomst = dateTimePicker2.Value.Date;
            string inpkm = akm.Text;
            double aantalkm = 0;
            decimal result = 0;
            TimeSpan tijdrit = aankomst - vertrek;
            int d = tijdrit.Days;
            int m = 0;
            int md = 0;
            if (d > 30)
            {
                m =  m + 1; md = m * 30;
            }
            try
            {
                double.TryParse(inpkm, out aantalkm);
            }
            catch (FormatException)
            {
                uitkomst.Text = "";
            }
            catch (OverflowException)
            {
                throw;
            }
            
            if (psa.Checked == true)
            {
                if (aantalkm > 100)
                {
                    double calc = ((aantalkm - 100) * 0.20) + (50 * d) + (md * 50);
                    result = System.Convert.ToDecimal(calc);
                    uitkomst.Text = result.ToString("€ ##.##");
                    int dvh = m + md;
                    dagen.Text = dvh.ToString();
                    psa.Checked = false;
                }
                else if (aantalkm < 100)
                {
                    double calc = (50 * d) + (md * 50);
                    result = System.Convert.ToDecimal(calc);
                    uitkomst.Text = result.ToString("€ ##.##");
                    int dvh = m + md;
                    dagen.Text = dvh.ToString();
                    psa.Checked = false;
                }
            }
            else if (psb.Checked == true)
            {
                double calc = (aantalkm * 0.30) + (95 * d) + (95 * md);
                result = System.Convert.ToDecimal(calc);
                uitkomst.Text = result.ToString("€ ##.##");
                int dvh = m + md;
                dagen.Text = dvh.ToString();
                psb.Checked = false;
            }
            else if (psb.Checked == false || psa.Checked == false)
            {
                uitkomst.Text = "Kies je soort voertuig";
            }
        }

        private void Bereken_Click(object sender, EventArgs e)
        {
            Berekenen();
        }
    }
}
