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
        bool t1 = false;
        bool t2 = false;
        public Form1()
        {
            InitializeComponent();
            InitializeDictionary();
        }
        private static Dictionary<char, string> _morseAlphabetDictionary;
        private static void InitializeDictionary()
        {
            _morseAlphabetDictionary = new Dictionary<char, string>()
            {
            {'a', ".-"},
            {'b', "-..."},
            {'c', "-.-."},
            {'d', "-.."},
            {'e', "."},
            {'f', "..-."},
            {'g', "--."},
            {'h', "...."},
            {'i', ".."},
            {'j', ".---"},
            {'k', "-.-"},
            {'l', ".-.."},
            {'m', "--"},
            {'n', "-."},
            {'o', "---"},
            {'p', ".--."},
            {'q', "--.-"},
            {'r', ".-."},
            {'s', "..."},
            {'t', "-"},
            {'u', "..-"},
            {'v', "...-"},
            {'w', ".--"},
            {'x', "-..-"},
            {'y', "-.--"},
            {'z', "--.."},

            {'0', "-----"},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},

            {' ', "/"},
            {'.', ".-.-.-"},
            {',', "--..--"},
            {':', "---..."},
            {'?', "..--.."},
            {'!', "..--."},
            {'\'', ".----."},
            {'-', "-....-"},
            {'/', "-..-."},
            {'"', ".-..-."},
            {'@', ".--.-."},
            {'=', "-...-"}
            };
        }
        private void Vertalen()
        {
            string TextOmTeVeranderen = "";
            string NieuweText = "";
            if (checkBox1.Checked == true)
            {
                TextOmTeVeranderen = textBox1.Text.ToLower();
                StringBuilder stringBuilder = new StringBuilder();
                foreach (char character in TextOmTeVeranderen)
                {
                    if (_morseAlphabetDictionary.ContainsKey(character))
                    {
                        stringBuilder.Append(_morseAlphabetDictionary[character] + " ");
                    }
                    else if (character == ' ')
                    {
                        stringBuilder.Append(" ");
                    }
                    else
                    {
                        stringBuilder.Append(character + " ");
                    }
                }
                NieuweText = stringBuilder.ToString();
                textBox2.Text = NieuweText;
            }
            else if (checkBox2.Checked == true)
            {
                string[] MTextOmTeVeranderen = textBox2.Text.ToLower().Trim().Split(' ');
                StringBuilder output = new StringBuilder();
                foreach (string s in MTextOmTeVeranderen)
                {
                    if (_morseAlphabetDictionary.ContainsValue(s))
                    {
                        output.Append(_morseAlphabetDictionary.FirstOrDefault(x => x.Value == s).Key);
                        textBox1.Text = output.ToString();
                    }
                }
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

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            checkBox1.Checked = false;
        }
    }
}
