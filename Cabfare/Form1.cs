using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabFare
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void DateVertrek_ValueChanged(object sender, EventArgs e)
        {
            var DV = DateVertrek.Value.ToString("dd MMMM, yyyy");
            input += DV;
            this.Awnser.Text += input;
        }

        private void TimeVertrek_ValueChanged(object sender, EventArgs e)
        {
            var TV = TimeVertrek.Value.ToString("HH:mm");
            input += TV;
            this.Awnser.Text += input;
        }

        private void DateAankomst_ValueChanged(object sender, EventArgs e)
        {
            var DA = DateAankomst.Value.ToString("dd MMMM, yyyy");
            input += DA;
            this.Awnser.Text += input;
        }

        private void TimeAankomst_ValueChanged(object sender, EventArgs e)
        {
            var TA = TimeAankomst.Value.ToString("HH:mm");
            input += TA;
            this.Awnser.Text += input;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
