using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabCostThing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void bereken_Click(object sender, EventArgs e)
        {
            kostendis.Text = "";
            int day = ((int)vdatum.Value.DayOfWeek + 6) % 7 + 1;
            DateTime vertrek = vdatum.Value.Date + vTime.Value.TimeOfDay;
            DateTime aankomst = adatum.Value.Date + aTime.Value.TimeOfDay;
            string aantalkm = this.aakm.Text;
            double dbaantalkm = Convert.ToDouble(aantalkm);
            double result = 0;
            double kmprz = 1 * dbaantalkm;

            if (day == 5 || day == 6 || day == 7)
            {
                if (vertrek.Hour > 08 || vertrek.Hour < 18)
                {
                    if (vertrek == aankomst)
                    {
                        kostendis.Text = "vertrek en aankomst tijd kan niet hetzelfde zijn";
                    }
                    else if (vertrek > aankomst)
                    {
                        kostendis.Text = "je kan niet vertrekken voor je aankomt";
                    }
                    else if (vertrek < aankomst)
                    {
                        TimeSpan tijdrit = aankomst - vertrek;
                        int m = tijdrit.Minutes;
                        int h = tijdrit.Hours;
                        double hk = (h * 60) * 0.45;
                        result = (m * 0.45) + hk + kmprz;
                        kostendis.Text = result.ToString("€ ##.##");
                    }
                }
                else if (vertrek.Hour < 8 || vertrek.Hour > 18)
                {
                    if (vertrek == aankomst)
                    {
                        kostendis.Text = "vertrek en aankomst tijd kan niet hetzelfde zijn";
                    }
                    else if (vertrek > aankomst)
                    {
                        kostendis.Text = "je kan niet vertrekken voor je aankomt";
                    }
                    else if (vertrek < aankomst)
                    {
                        if (vertrek.Hour > 22 || vertrek.Hour < 7)
                        {
                            TimeSpan tijdrit = aankomst - vertrek;
                            int h = tijdrit.Hours;
                            int m = tijdrit.Minutes;
                            double hk = (h * 60) * 0.45;
                            double procnt = ((m * 0.45) + hk) / 100 * 15;
                            double kmprocnt = (kmprz / 100) * 15;
                            result = (m * 0.45) + hk + procnt + kmprz + kmprocnt;
                            kostendis.Text = result.ToString("€ ##.##");
                        }
                        else if (vertrek.Hour < 22 || vertrek.Hour > 7)
                        {
                            if ((vertrek.Hour < 08 || vertrek.Hour > 18))
                            {
                                TimeSpan tijdrit = aankomst - vertrek;
                                int m = tijdrit.Minutes;
                                int h = tijdrit.Hours;
                                double hk = (h * 60) * 0.45;
                                result = (m * 0.45) + hk + kmprz;
                                kostendis.Text = result.ToString("€ ##.##");
                            }
                            else if ((vertrek.Hour > 08 || vertrek.Hour < 18))
                            {
                                TimeSpan tijdrit = aankomst - vertrek;
                                int m = tijdrit.Minutes;
                                int h = tijdrit.Hours;
                                double hk = (h * 60) * 0.25;
                                result = (m * 0.25) + hk + kmprz;
                                kostendis.Text = result.ToString("€ ##.##");
                            }
                        }
                    }
                }
            }
        
                else if (vertrek.Hour < 08 || vertrek.Hour > 18)
                {
                    if (vertrek == aankomst)
                    {
                        kostendis.Text = "vertrek en aankomst tijd kan niet hetzelfde zijn";
                    }
                    else if (vertrek > aankomst)
                    {
                        kostendis.Text = "je kan niet vertrekken voor je aankomt";
                    }
                    else if (vertrek < aankomst)
                    {
                    TimeSpan tijdrit = aankomst - vertrek;
                    int m = tijdrit.Minutes;
                    int h = tijdrit.Hours;
                    double hk = (h * 60) * 0.45;
                    result = (m * 0.45) + hk + kmprz;
                    kostendis.Text = result.ToString("€ ##.##");
                    }
                }
            
            else if (vertrek.Hour > 08 || vertrek.Hour < 18)
            {
                if (vertrek == aankomst)
                {
                    kostendis.Text = "vertrek en aankomst tijd kan niet hetzelfde zijn";
                }
                else if (vertrek > aankomst)
                {
                    kostendis.Text = "je kan niet vertrekken voor je aankomt";
                }
                else if (vertrek < aankomst)
                {
                    TimeSpan tijdrit = aankomst - vertrek;
                    int m = tijdrit.Minutes;
                    int h = tijdrit.Hours;
                    double hk = (h * 60) * 0.25;
                    result = (m * 0.25) + hk + kmprz;
                    kostendis.Text = result.ToString("€ ##.##");
                }
            }
            else if (vertrek.Hour < 8 || vertrek.Hour > 18)
            {
                if (vertrek == aankomst)
                {
                    kostendis.Text = "vertrek en aankomst tijd kan niet hetzelfde zijn";
                }
                else if (vertrek > aankomst)
                {
                    kostendis.Text = "je kan niet vertrekken voor je aankomt";
                }
                else if (vertrek < aankomst)
                {
                    TimeSpan tijdrit = aankomst - vertrek;
                    int m = tijdrit.Minutes;
                    int h = tijdrit.Hours;
                    double hk = (h * 60) * 0.45;
                    result = (m * 0.45) + hk + kmprz;
                    kostendis.Text = result.ToString("€ ##.##");
                }
            }

        }
    }
}

