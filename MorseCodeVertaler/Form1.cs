using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCodeVertaler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Dictionary<char, string> _morseAlphabetDictionary;
        private static void InitializeDictionary()
        {
            _morseAlphabetDictionary = new Dictionary<char, string>()
            {
                {'a', ". ___ "}, {'b', "___ . . . " }, {'c', "___ . ___ . "},
                {'d', "___ . . "}, {'e', ". "}, {'f', ". . ___ . "},
                {'g', "___ ___ . "}, {'h', ". . . . "}, {'i', ". . "},
                {'j', ". ___ ___ ___ "}, {'k', "___ . ___ "}, {'l', ". ___ . . "},
                {'m', "___ ___ "}, {'n', "___ . "}, {'o', "___ ___ ___ "},
                {'p', ". ___ ___ . "}, {'q', "___ ___ . ___ "}, {'r', ". ___ . "},
                {'s', ". . . "}, {'t', "___ "}, {'u', ". . ___ "},
                {'v', ". . . ___ "}, {'w', ". ___ ___ "}, {'x', "___ . . ___ "},
                {'y', "___ . ___ ___ "}, {'z', "___ ___ . ."}, {'0', "___ ___ ___ ___ ___ "},
                {'1', ". ___ ___ ___ ___ "}, {'2', ". . ___ ___ ___ "}, {'3', ". . . ___ ___ "},
                {'4', ". . . . ___ "}, {'5', ". . . . . "}, {'6', "___ . . . . "},
                {'7', "___ ___ . . . "}, {'8', "___ ___ ___ . . "}, {'9', "___ ___ ___ ___ . "},
                {'.', ". ___ . ___ . ___ "}, {',', "___ ___ . . ___ ___ "}, {'?', ". . ___ ___ . . "},
                {'!', "___ . ___ . ___ ___ "}, {'-', " ___ . . . . ___"}
            };
        }

        private void Vertalen()
        {
            string TextOmTeVeranderen = "";
            string NieuweText = "";

            if (checkBox1.Checked == true)
            {
                StringBuilder stringBuilder = new StringBuilder();
            }
            else if (checkBox2.Checked == true)
            {
            }


            else if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                textBox1.Text = "typ iets in";
            }

        }
                private void vertaal_Click(object sender, EventArgs e)
                {
                    Vertalen();
                }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }
    }
}
