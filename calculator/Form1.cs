using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NieuweRekenMachine
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operant1 = string.Empty;
        string operant2 = string.Empty;
        char operation;
        double result = 0.0;
        double Cresult = 0.0;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPreview = true;
            if (e.KeyChar == 'c')
            {
                clear.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D0)
            {
                zero.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D1)
            {
                one.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D2)
            {
                two.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D3)
            {
                three.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D4)
            {
                four.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D5)
            {
                five.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D6)
            {
                six.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D7)
            {
                seven.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D8)
            {
                eight.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D9)
            {
                nine.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad0)
            {
                zero.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad1)
            {
                one.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad2)
            {
                two.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad3)
            {
                three.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad4)
            {
                four.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad5)
            {
                five.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad6)
            {
                six.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad7)
            {
                seven.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad8)
            {
                eight.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.NumPad9)
            {
                nine.PerformClick();
            }
            else if (e.KeyChar == '-')
            {
                minus.PerformClick();
            }
            else if (e.KeyChar == '+')
            {
                plus.PerformClick();
            }
            else if (e.KeyChar == '*')
            {
                multiply.PerformClick();
            }
            else if (e.KeyChar == '.')
            {
                dot.PerformClick();
            }
            else if (e.KeyChar == '/')
            {
                devide.PerformClick();
            }
            else if (e.KeyChar == 'c')
            {
                clear.PerformClick();
            }
        }

        private void devide_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            operant1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            this.textBox1.Text = "";
            operant1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            operant1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            operant1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void procentage_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            operant1 = input;
            operation = '%';
            input = string.Empty;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            input += "0";
            this.textBox1.Text += input;
            this.textBox2.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            input += "1";
            this.textBox1.Text += input;
            this.textBox2.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            input += "2";
            this.textBox1.Text += input;
            this.textBox2.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            input += "3";
            this.textBox1.Text += input;
            this.textBox2.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            input += "4";
            this.textBox1.Text += input;
            this.textBox2.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            input += "5";
            this.textBox1.Text += input;
            this.textBox2.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            input += "6";
            this.textBox1.Text += input;
            this.textBox2.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            input += "7";
            this.textBox1.Text += input;
            this.textBox2.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            input += "8";
            this.textBox1.Text += input;
            this.textBox2.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            input += "9";
            this.textBox1.Text += input;
            this.textBox2.Text += input;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            input += ",";
            this.textBox1.Text += input;
            this.textBox2.Text += input;
        }

        private void Calculating()
        {
            operant2 = input;
            double num1, num2;
            double.TryParse(operant1, out num1);
            double.TryParse(operant2, out num2);

            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operant1 = string.Empty;
            this.operant2 = string.Empty;

            if (operation == '/')
            {
                if (num1 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                    this.textBox2.Text = "";
                }
                else
                {
                    textBox1.Text = "DIV/ZERO!";
                    this.textBox2.Text = "";
                }
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
                this.textBox2.Text = "";
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
                this.textBox2.Text = "";
            }
            else if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
                this.textBox2.Text = "";
            }
            else if (operation == '%')
            {
                if (num1 != 0)
                {
                    result = (num2 / 100) * num1;
                    textBox1.Text = result.ToString();
                    this.textBox2.Text = "";
                }
                else
                {
                    textBox1.Text = "Need an bigger % than 0";
                    this.textBox2.Text = "";
                }
            }
        }
        private void calculate_Click(object sender, EventArgs e)
        {
            Calculating();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.input = string.Empty;
            this.operant1 = string.Empty;
            this.operant2 = string.Empty;
        }

        private void root_Click(object sender, EventArgs e)
        {
            operant2 = input;
            double num1;
            double.TryParse(operant2, out num1);

            var result = Math.Sqrt(num1);
            textBox1.Text = result.ToString();
            this.textBox2.Text = "";
        }

        private void Valutarek()
        {
            if (dollarwasclicked == true)
            {
                if (input == "")
                {
                    textBox3.Text = "Typ eerst je getal in Euro dat je wilt converten.";
                }
                else
                {
                    operant2 = input;
                    double num1;
                    double.TryParse(operant2, out num1);
                    decimal Dawnser;

                    Cresult = num1 * 1.08;
                    Dawnser = Convert.ToDecimal(Cresult);
                    textBox3.Text = Dawnser.ToString("$ ##.##");

                    valuta.Text = "Dollar";
                    dollarwasclicked = false;
                }
            }

            else if (yenwasclicked == true)
            {
                if (input == "")
                {
                    textBox3.Text = "Typ eerst je getal in Euro dat je wilt converten.";
                }
                else
                {
                    operant2 = input;
                    double num1;
                    double.TryParse(operant2, out num1);
                    decimal Dawnser;

                    Cresult = num1 * 120.36;
                    Dawnser = Convert.ToDecimal(Cresult);
                    textBox3.Text = Dawnser.ToString("¥ ##.##");

                    valuta.Text = "Yen";
                    yenwasclicked = false;
                }
            }
            else if (pondenwasclicked == true)
            {
                if (input == "")
                {
                    textBox3.Text = "Typ eerst je getal in euro dat je wilt converten.";
                }
                else
                {
                    operant2 = input;
                    double num1;
                    double.TryParse(operant2, out num1);
                    decimal Dawnser;

                    Cresult = num1 * 0.84;
                    Dawnser = Convert.ToDecimal(Cresult);
                    textBox3.Text = Dawnser.ToString("£ ##.##");

                    valuta.Text = "Pond";
                    pondenwasclicked = false;
                }
            }
            else if (roebelwasclicked == true)
            {
                if (input == "")
                {
                    textBox3.Text = "Typ eerst je getal in Euro dat je wilt converten.";
                }
                else
                {
                    operant2 = input;
                    double num1;
                    double.TryParse(operant2, out num1);
                    decimal Dawnser;

                    Cresult = num1 * 70.70;
                    Dawnser = Convert.ToDecimal(Cresult);
                    textBox3.Text = Dawnser.ToString("₽ ##.##");

                    valuta.Text = "Roebel";
                    roebelwasclicked = false;
                }


            }

                } 
        private bool dollarwasclicked = false;
        private bool yenwasclicked = false;
        private bool pondenwasclicked = false;
        private bool roebelwasclicked = false;
        private void dollar_Click(object sender, EventArgs e)
        {
            dollarwasclicked = true;
            Valutarek();
        }

        private void yen_Click(object sender, EventArgs e)
        {
            yenwasclicked = true;
            Valutarek(); 
        }
    
        private void ponden_Click(object sender, EventArgs e)
        {
            pondenwasclicked = true;
            Valutarek();
        }

        private void roebel_Click(object sender, EventArgs e)
        {
            roebelwasclicked = true;
            Valutarek();
        }
    }
}


