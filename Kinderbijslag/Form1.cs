using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinderbijslag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            checkBox4.Checked = true;
        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            checkBox5.Checked = true;
        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {
            checkBox6.Checked = true;
        }

        private void dateTimePicker7_ValueChanged(object sender, EventArgs e)
        {
            checkBox7.Checked = true;
        }

        private void dateTimePicker8_ValueChanged(object sender, EventArgs e)
        {
            checkBox8.Checked = true;
        }

        private void dateTimePicker9_ValueChanged(object sender, EventArgs e)
        {
            checkBox9.Checked = true;
        }

        private void dateTimePicker10_ValueChanged(object sender, EventArgs e)
        {
            checkBox10.Checked = true;
        }

        private void berekenen()
        {
            DateTime checkdate = DateTime.Now.Date;
            int act = 0;
            double result = 0;
            DateTime k1 = dateTimePicker1.Value.Date; int KB1 = 0;
            DateTime k2 = dateTimePicker2.Value.Date; int KB2 = 0;
            DateTime k3 = dateTimePicker3.Value.Date; int KB3 = 0;
            DateTime k4 = dateTimePicker4.Value.Date; int KB4 = 0;
            DateTime k5 = dateTimePicker5.Value.Date; int KB5 = 0;
            DateTime k6 = dateTimePicker6.Value.Date; int KB6 = 0;
            DateTime k7 = dateTimePicker7.Value.Date; int KB7 = 0;
            DateTime k8 = dateTimePicker8.Value.Date; int KB8 = 0;
            DateTime k9 = dateTimePicker9.Value.Date; int KB9 = 0;
            DateTime k10 = dateTimePicker10.Value.Date; int KB10 = 0;
            if (checkBox1.Checked == true)
            {
                if (dateTimePicker1.Value.Date != checkdate.Date)
                {
                    TimeSpan checkage = checkdate - k1;
                    double year = checkage.TotalDays / 365.242199;
                    if (year < 12)
                    {
                        KB1 = 150;
                        act++;
                    }
                    else if (year > 12 && year < 18)
                    {
                        KB1 = 235;
                        act++;
                    }
                    else if (year > 18)
                    {
                        KB1 = 0;
                    }
                }

                else
                {
                    Geldig1.Text = "Niet Geldig";
                    KB1 = 0;
                }
            }

            if (checkBox2.Checked == true)
            {
                if (dateTimePicker2.Value.Date != checkdate.Date)
                {
                    TimeSpan checkage = checkdate - k2;
                    double year = checkage.TotalDays / 365.242199;
                    if (year < 12)
                    {
                        KB2 = 150;
                        act++;
                    }
                    else if (year > 12 && year < 18)
                    {
                        KB2 = 235;
                        act++;
                    }
                    else if (year > 18)
                    {
                        KB2 = 0;
                    }
                }
                else
                {
                    Geldig2.Text = "Niet Geldig";
                    KB2 = 0;
                }

            }
            if (checkBox3.Checked == true)
            {
                if (dateTimePicker3.Value.Date != checkdate.Date)
                {
                    TimeSpan checkage = checkdate - k3;
                    double year = checkage.TotalDays / 365.242199;
                    if (year < 12)
                    {
                        KB3 = 150;
                        act++;
                    }
                    else if (year > 12 && year < 18)
                    {
                        KB3 = 235;
                        act++;
                    }
                    else if (year > 18)
                    {
                        KB3 = 0;
                    }
                }
                else
                {
                    Geldig3.Text = "Niet Geldig";
                    KB3 = 0;
                }

            }
            if (checkBox4.Checked == true)
            {
                if (dateTimePicker4.Value.Date != checkdate.Date)
                {
                    TimeSpan checkage = checkdate - k4;
                    double year = checkage.TotalDays / 365.242199;
                    if (year < 12)
                    {
                        KB4 = 150;
                        act++;
                    }
                    else if (year > 12 && year < 18)
                    {
                        KB4 = 235;
                        act++;
                    }
                    else if (year > 18)
                    {
                        KB4 = 0;
                    }
                }
                else
                {
                    Geldig4.Text = "Niet Geldig";
                    KB4 = 0;
                }
            }
            if (checkBox5.Checked == true)
            {
                if (dateTimePicker5.Value.Date != checkdate.Date)
                {
                    TimeSpan checkage = checkdate - k5;
                    double year = checkage.TotalDays / 365.242199;
                    if (year < 12)
                    {
                        KB5 = 150;
                        act++;
                    }
                    else if (year > 12 && year < 18)
                    {
                        KB5 = 235;
                        act++;
                    }
                    else if (year > 18)
                    {
                        KB5 = 0;
                    }
                }
                else
                {
                    Geldig5.Text = "Niet Geldig";
                    KB5 = 0;
                }
            }

            if (checkBox6.Checked == true)
            {
                if (dateTimePicker6.Value.Date != checkdate.Date)
                {
                    TimeSpan checkage = checkdate - k6;
                    double year = checkage.TotalDays / 365.242199;
                    if (year < 12)
                    {
                        KB6 = 150;
                        act++;
                    }
                    else if (year > 12 && year < 18)
                    {
                        KB6 = 235;
                        act++;
                    }
                    else if (year > 18)
                    {
                        KB6 = 0;
                    }
                }
                else
                {
                    Geldig6.Text = "Niet Geldig";
                    KB6 = 0;
                }
            }

            if (checkBox7.Checked == true)
            {
                if (dateTimePicker7.Value.Date != checkdate.Date)
                {
                    TimeSpan checkage = checkdate - k7;
                    double year = checkage.TotalDays / 365.242199;
                    if (year < 12)
                    {
                        KB7 = 150;
                        act++;
                    }
                    else if (year > 12 && year < 18)
                    {
                        KB7 = 235;
                        act++;
                    }
                    else if (year > 18)
                    {
                        KB7 = 0;
                    }
                }
                else
                {
                    Geldig7.Text = "Niet Geldig";
                    KB7 = 0;
                }
            }

            if (checkBox8.Checked == true)
            {
                if (dateTimePicker8.Value.Date != checkdate.Date)
                {
                    act++;
                    TimeSpan checkage = checkdate - k8;
                    double year = checkage.TotalDays / 365.242199;
                    if (year < 12)
                    {
                        KB8 = 150;
                        act++;
                    }
                    else if (year > 12 && year < 18)
                    {
                        KB8 = 235;
                        act++;
                    }
                    else if (year > 18)
                    {
                        KB8 = 0;
                    }
                }
                else
                {
                    Geldig8.Text = "Niet Geldig";
                    KB8 = 0;
                }
            }

            if (checkBox9.Checked == true)
            {
                if (dateTimePicker9.Value.Date != checkdate.Date)
                {
                    TimeSpan checkage = checkdate - k9;
                    double year = checkage.TotalDays / 365.242199;
                    if (year < 12)
                    {
                        KB9 = 150;
                        act++;
                    }
                    else if (year > 12 && year < 18)
                    {
                        KB9 = 235;
                        act++;
                    }
                    else if (year > 18)
                    {
                        KB9 = 0;
                    }
                }
                else
                {
                    Geldig9.Text = "Niet Geldig";
                    KB9 = 0;
                }
            }

            if (checkBox10.Checked == true)
            {
                if (dateTimePicker10.Value.Date != checkdate.Date)
                {
                    
                    TimeSpan checkage = checkdate - k10;
                    double year = checkage.TotalDays / 365.242199;
                    if (year < 12)
                    {
                        KB10 = 150;
                        act++;
                    }
                    else if (year > 12 && year < 18)
                    {
                        KB10 = 235;
                        act++;
                    }
                    else if (year > 18)
                    {
                        KB10 = 0;
                    }
                }
                else
                {
                    Geldig10.Text = "Niet Geldig";
                    KB10 = 0;
                }
            }
            double allkb = KB1 + KB2 + KB3 + KB4 + KB5 + KB6 + KB7 + KB8 + KB9 + KB10;
            if (act == 3 || act > 3 && act < 5)
            {
                double procnt = (allkb / 100) * 2;
                Uitkomst.Text = (allkb + procnt).ToString("€ ##.##");
            }
            else if (act == 5)
            {
                double procnt = (allkb / 100) * 3;
                Uitkomst.Text = (allkb + procnt).ToString("€ ##.##");
            }
            else if (act == 6 || act > 6)
            {
                double procnt = (allkb / 100) * 3.5;
                Uitkomst.Text = (allkb + procnt).ToString("€ ##.##");
            }
            else if (act < 3)
            {
                Uitkomst.Text = allkb.ToString("€ ##.##");
            }
        }
            private void bereken_Click(object sender, EventArgs e)
            {
                berekenen();
            }

    }
}

