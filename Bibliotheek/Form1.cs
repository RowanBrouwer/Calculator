using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bereken()
        {
            telaat.Text = "";
            tld.Text = "";
            prijs.Text = "";
            DateTime uitgeleend = dateTimePicker1.Value.Date;
            DateTime ingeleverd = dateTimePicker2.Value.Date;
            TimeSpan dagen = ingeleverd - uitgeleend;
            int d = dagen.Days;
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                prijs.Text = "Kies 1 soort boek dat word ingeleverd";
            }
            else if (checkBox1.Checked == true)
            {
                if (d > 21)
                {
                    telaat.Text = "Ja";
                    double boete = (d - 21) * 0.25;
                    System.Convert.ToDecimal(boete);
                    prijs.Text = boete.ToString("€ ##.##");
                    tld.Text = (d - 21).ToString();
                    checkBox1.Checked = false;
                }
                else if (d < 21)
                {
                    telaat.Text = "Nee";
                    checkBox1.Checked = false;
                }
            }
            else if (checkBox2.Checked == true)
            {
                if (d > 30)
                {
                    int week = 7;
                    double wekenlaat = (d - 30) / week;
                    double boete = wekenlaat * 1;
                    System.Convert.ToDecimal(boete);
                    prijs.Text = boete.ToString("€ ##.##");
                    tld.Text = (d - 30).ToString();
                    checkBox2.Checked = false;
                }
                else if (d < 30)
                {
                    telaat.Text = "Nee";
                    checkBox1.Checked = false;
                }
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                prijs.Text = "Kies het soort boek dat word ingeleverd";
            }

        }

        private void check_Click(object sender, EventArgs e)
        {
            Bereken();
        }

    }
}
