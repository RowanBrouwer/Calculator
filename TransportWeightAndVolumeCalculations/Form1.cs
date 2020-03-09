using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportWeightAndVolumeCalculations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.vervoerskosten.Text = "";
        }

        private void Action()
        {
            var inputCM = this.cubiekemeters.Text;
            var inputKG = this.kilogram.Text;
            var inputKM = this.kilometers.Text;
            var bkm = this.Bkm.Text;
            this.vervoerskosten.Text = "";
            double vcpn = 0.80;
            double gcpn = 0.55;
            double vcpv = 1.25;
            double gcpv = 0.45;
            double iCM = 0;
            double iKG = 0;
            double iKM = 0;
            double ibkm = 0;
            try
            {
                iCM = System.Convert.ToDouble(inputCM);
                iKG = System.Convert.ToDouble(inputKG);
                iKM = System.Convert.ToDouble(inputKM);
                ibkm = System.Convert.ToDouble(bkm);
            }
            catch (FormatException)
            {
                ibkm = 0;
            }
            catch (OverflowException)
            {
                throw;
            }

            if (bldp.Text == "Nee")
            {
                if (vloeibaardp.Text == "Nee")
                {
                    decimal apprkml;
                    this.vervoerskosten.Text = "";
                    double vcppr = iCM * vcpn;
                    double gcppr = iKG * gcpn;
                    double pprkmnl = vcppr + gcppr * iKM;
                    try
                    {
                        apprkml = System.Convert.ToDecimal(pprkmnl);
                    }
                    catch (FormatException)
                    {
                        throw;
                    }
                    catch (OverflowException)
                    {
                        throw;
                    }
                    vervoerskosten.Text = apprkml.ToString("€ ##.##-");
                }
                else if (vloeibaardp.Text == "Ja")
                {
                    decimal apprkmvnl;
                    this.vervoerskosten.Text = "";
                    double vcppr = iCM * vcpv;
                    double gcppr = iKG * gcpv;
                    double pprkmvnl = vcppr + gcppr * iKM;
                    try
                    {
                        apprkmvnl = System.Convert.ToDecimal(pprkmvnl);
                    }
                    catch (FormatException)
                    {
                        throw;
                    }
                    catch (OverflowException)
                    {
                        throw;
                    }
                    vervoerskosten.Text = apprkmvnl.ToString("€ ##.##-");
                }
            }
            if (bldp.Text == "Ja")
            {

                if (vloeibaardp.Text == "Nee")
                {
                    decimal afull;
                    decimal aless;
                    this.vervoerskosten.Text = "";
                    double vcppr = iCM * vcpn;
                    double gcppr = iKG * gcpn;
                    double nmpprr = vcppr + gcppr * ibkm;
                    double rest = iKM - ibkm;
                    double tppkm = vcppr + gcppr;
                    double pprkmnl = rest * tppkm;
                    double pprkmbl = ibkm * tppkm;
                    double pc = pprkmbl / 100;
                    double ts = pc * 45;
                    double duane = pc * 3.5;
                    double rpbl = pprkmnl + pprkmbl;
                    double full = rpbl + ts + duane;
                    double less = rpbl + ts + 45;
                    try
                    {
                        afull = System.Convert.ToDecimal(full);
                        aless = System.Convert.ToDecimal(less);
                    }
                    catch (FormatException)
                    {
                        throw;
                    }
                    catch (OverflowException)
                    {
                        throw;
                    }

                    if (duane > 45)
                    {
                        vervoerskosten.Text = afull.ToString("€ ##.##-");
                    }
                    else if (duane < 45)
                    {
                        vervoerskosten.Text = aless.ToString("€ ##.##-");
                    }
                }
                else if (vloeibaardp.Text == "Ja")
                {
                    decimal afull;
                    decimal aless;
                    this.vervoerskosten.Text = "";
                    double vcpprv = iCM * vcpv;
                    double gcpprv = iKG * gcpv;
                    double nmpprr = vcpprv + gcpprv * ibkm;
                    double rest = iKM - ibkm;
                    double tppkm = vcpprv + gcpprv;
                    double pprkmnl = rest * tppkm;
                    double pprkmbl = ibkm * tppkm;
                    double pc = nmpprr / 100;
                    double ts = pc * 45;
                    double duane = pc * 3.5;
                    double rpbl = pprkmnl + pprkmbl;
                    double full = rpbl + ts + duane;
                    double less = rpbl + ts + 45;
                    try
                    {
                        afull = System.Convert.ToDecimal(full);
                        aless = System.Convert.ToDecimal(less);
                    }
                    catch (FormatException)
                    {
                        throw;
                    }
                    catch (OverflowException)
                    {
                        throw;
                    }
                    if (duane < 45)
                    {
                        vervoerskosten.Text = aless.ToString("€ ##.##");
                    }
                    else if (duane > 45)
                    {
                        vervoerskosten.Text = afull.ToString("€ ##.##");
                    }
                }
            }
        }





        private void Bereken_Click(object sender, EventArgs e)
        {
            Action();
        }

        private void bldp_SelectedIndexChanged(object sender, EventArgs e)
        {
            bldp.Text.ToString();
        }

        private void vloeibaardp_SelectedIndexChanged(object sender, EventArgs e)
        {
            bldp.Text.ToString();
        }
    }
}  


