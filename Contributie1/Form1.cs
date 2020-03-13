using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contributie1
{
    public partial class Form1 : Form
    {
        public DateTime MaxDate { get; set; }
 
        public Form1()
        {
            InitializeComponent();
        }
        private void berekenen()
        {
            Uitkomst.Text = "";
            DateTime check = DateTime.Now.Date;
            DateTime b1 = dateTimePicker1.Value.Date;
            DateTime l1 = dateTimePicker2.Value.Date;
            TimeSpan checkage = check - b1;
            TimeSpan checklid = check - l1;
            double Age = checkage.TotalDays / 365.242199;
            double Lid = checklid.TotalDays / 365.242199;
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now;

            if (dateTimePicker1.Value.Date.Date != check)
            {
                if (Age > 18)
                {
                    int contri = 75;
                    double yrek = contri + 45;
                    double ypro = yrek / 100;
                    double nrek = contri;
                    double npro = nrek / 100;

                    if (wel.Checked == true)
                    {
                        if (Lid  > 7)
                        {
                            double kort = ypro * 3.5;
                            Uitkomst.Text = (yrek - kort).ToString("€ ##.##");
                        }
                        else if (Lid == 4 || Lid > 4 && Lid <7)
                        {
                            double kort = ypro * 2;
                            Uitkomst.Text = (yrek - kort).ToString("€ ##.##");
                        }
                        else if (Lid < 4)
                        {
                            Uitkomst.Text = yrek.ToString("€ ##.##");
                        }
                    }
                    else if (niet.Checked == true)
                    {
                        if (Lid > 7)
                        {
                            double kort = npro * 3.5;
                            Uitkomst.Text = (nrek - kort).ToString("€ ##.##");
                        }
                        else if (Lid == 4 || Lid > 4 && Lid < 7)
                        {
                            double kort = npro * 2;
                            Uitkomst.Text = (nrek - kort).ToString("€ ##.##");
                        }
                        else if (Lid < 4)
                        {
                            Uitkomst.Text = nrek.ToString("€ ##.##");
                        }
                    }
                    else if (wel.Checked && niet.Checked == false)
                    {
                        Uitkomst.Text = "Selecteer of je wel of niet actief spelend lid bent";
                    }
                }
                else if (Age < 18)
                {
                    int contri = 40;
                    double yrek = contri + 45;
                    double ypro = yrek / 100;
                    double nrek = contri;
                    double npro = nrek / 100;

                    if (wel.Checked == true)
                    {
                        if (Lid > 7)
                        {
                            double kort = ypro * 3.5;
                            Uitkomst.Text = (yrek - kort).ToString("€ ##.##");
                        }
                        else if (Lid == 4 || Lid > 4 && Lid < 7)
                        {
                            double kort = ypro * 2;
                            Uitkomst.Text = (yrek - kort).ToString("€ ##.##");
                        }
                        else if (Lid < 4)
                        {
                            Uitkomst.Text = yrek.ToString("€ ##.##");
                        }
                    }
                    else if (niet.Checked == true)
                    {
                        if (Lid > 7)
                        {
                            double kort = npro * 3.5;
                            Uitkomst.Text = (nrek - kort).ToString("€ ##.##");
                        }
                        else if (Lid == 4 || Lid > 4 && Lid < 7)
                        {
                            double kort = npro * 2;
                            Uitkomst.Text = (nrek - kort).ToString("€ ##.##");
                        }
                        else if (Lid < 4)
                        {
                            Uitkomst.Text = nrek.ToString("€ ##.##");
                        }
                    }
                    else if (wel.Checked && niet.Checked == false)
                    {
                        Uitkomst.Text = "Selecteer of je wel of niet actief spelend lid bent";
                    }
                }
            }
            else if (dateTimePicker1.Value.Date == check)
            {
                Uitkomst.Text = "voer een geldige geboortedatum in";
            }
        }

        private void wel_CheckedChanged(object sender, EventArgs e)
        {
            niet.Checked = false;
        }

        private void niet_CheckedChanged(object sender, EventArgs e)
        {
            wel.Checked = false;
        }

        private void Bereken_Click(object sender, EventArgs e)
        {
            berekenen();
        }
    }
}
