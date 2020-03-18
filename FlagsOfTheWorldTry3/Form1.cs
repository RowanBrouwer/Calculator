using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagsOfTheWorldTry3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            generate();
        }

        private void beantwoord_Click(object sender, EventArgs e)
        {
            check_awnser();
        }

        private void generate()
        {
            country.ForeColor = Color.Black;
            int a = 0;
            this.country.Text = "";
            textBox1.Text = "";
            Random r = new Random();
            int R = r.Next(1, 197);
            string path = @"C:\Users\Rowan\Desktop\Important\Flags\";
            pictureBox1.Image = Image.FromFile(path + R.ToString() + ".png");
            if (R == 1)
            {
                this.country.Text = "Albania";
                a = 1;
            }
            else if (R == 2)
            {
                this.country.Text = "Algeria";
                a = 2;
            }
            else if (R == 3)
            {
                this.country.Text = "Andorra";
                a = 3;
            }
            else if (R == 4)
            {
                this.country.Text = "Angola";
                a = 4;
            }
            else if (R == 5)
            {
                this.country.Text = "Antigua and Barbuda";
                a = 5;
            }
            else if (R == 6)
            {
                this.country.Text = "Argentina";
                a = 6;
            }
            else if (R == 7)
            {
                this.country.Text = "Armenia";
                a = 7;
            }
            else if (R == 8)
            {
                this.country.Text = "Australia";
                a = 8;
            }
            else if (R == 9)
            {
                this.country.Text = "Austria";
                a = 9;
            }
            else if (R == 10)
            {
                this.country.Text = "Azerbaijan";
                a = 10;
            }
            else if (R == 11)
            {
                this.country.Text = "Bahamas";
                a = 11;
            }
            else if (R == 12)
            {
                this.country.Text = "Bahrain";
                a = 12;
            }
            else if (R == 13)
            {
                this.country.Text = "Bangladesh";
                a = 13;
            }
            else if (R == 14)
            {
                this.country.Text = "Barbados";
                a = 14;
            }
            else if (R == 15)
            {
                this.country.Text = "Belarus";
                a = 15;
            }
            else if (R == 16)
            {
                this.country.Text = "Belize";
                a = 16;
            }
            else if (R == 17)
            {
                this.country.Text = "Benin";
                a = 17;
            }
            else if (R == 18)
            {
                this.country.Text = "Bhutan";
                a = 18;
            }
            else if (R == 19)
            {
                this.country.Text = "Bolivia";
                a = 19;
            }
            else if (R == 20)
            {
                this.country.Text = "Bosnia and Herzegovina";
                a = 20;
            }
            else if (R == 21)
            {
                this.country.Text = "Botswana";
                a = 21;
            }
            else if (R == 22)
            {
                this.country.Text = "Brazil";
                a = 22;
            }
            else if (R == 23)
            {
                this.country.Text = "Brunei";
                a = 23;
            }
            else if (R == 24)
            {
                this.country.Text = "Bulgaria";
                a = 24;
            }
            else if (R == 25)
            {
                this.country.Text = "Burkina Faso";
                a = 25;
            }
            else if (R == 26)
            {
                this.country.Text = "Burundi";
                a = 26;
            }
            else if (R == 27)
            {
                this.country.Text = "Cabo Verde";
                a = 27;
            }
            else if (R == 28)
            {
                this.country.Text = "Cambodia";
                a = 28;
            }
            else if (R == 29)
            {
                this.country.Text = "Cameroon";
                a = 29;
            }
            else if (R == 30)
            {
                this.country.Text = "Canada";
                a = 30;
            }
            else if (R == 31)
            {
                this.country.Text = "Central African Republic";
                a = 31;
            }
            else if (R == 32)
            {
                this.country.Text = "Chad";
                a = 32;
            }
            else if (R == 33)
            {
                this.country.Text = "Chile";
                a = 33;
            }
            else if (R == 34)
            {
                this.country.Text = "China";
                a = 34;
            }
            else if (R == 35)
            {
                this.country.Text = "Colombia";
                a = 35;
            }
            else if (R == 36)
            {
                this.country.Text = "Comoros";
                a = 36;
            }
            else if (R == 37)
            {
                this.country.Text = "Republic of the Congo";
                a = 37;
            }
            else if (R == 38)
            {
                this.country.Text = "Democratic Republic of the Congo";
                a = 38;
            }
            else if (R == 39)
            {
                this.country.Text = "Costa Rica";
                a = 39;
            }
            else if (R == 40)
            {
                this.country.Text = "Cote d'Ivoire";
                a = 40;
            }
            else if (R == 41)
            {
                this.country.Text = "Croatia";
                a = 41;
            }
            else if (R == 42)
            {
                this.country.Text = "Cuba";
                a = 42;
            }
            else if (R == 43)
            {
                this.country.Text = "Cyprus";
                a = 43;
            }
            else if (R == 44)
            {
                this.country.Text = "Czechia";
                a = 44;
            }
            else if (R == 45)
            {
                this.country.Text = "Denmark";
                a = 45;
            }
            else if (R == 46)
            {
                this.country.Text = "Djibouti";
                a = 46;
            }
            else if (R == 47)
            {
                this.country.Text = "Dominica";
                a = 47;
            }
            else if (R == 48)
            {
                this.country.Text = "Dominican Republic";
                a = 48;
            }
            else if (R == 49)
            {
                this.country.Text = "Ecuador";
                a = 49;
            }
            else if (R == 50)
            {
                this.country.Text = "Egypt";
                a = 50;
            }
            else if (R == 51)
            {
                this.country.Text = "El Salvador";
                a = 51;
            }
            else if (R == 52)
            {
                this.country.Text = "Equitorial Guinea";
                a = 52;
            }
            else if (R == 53)
            {
                this.country.Text = "Eritrea"; a = 53;
            }
            else if (R == 54)
            {
                this.country.Text = "Estonia"; a = 54;
            }
            else if (R == 55)
            {
                this.country.Text = "Eswatini"; a = 55;
            }
            else if (R == 56)
            {
                this.country.Text = "Ethiopia"; a = 56;
            }
            else if (R == 57)
            {
                this.country.Text = "Fiji"; a = 57;
            }
            else if (R == 58)
            {
                this.country.Text = "Finland"; a = 58;
            }
            else if (R == 59)
            {
                this.country.Text = "France"; a = 59;
            }
            else if (R == 60)
            {
                this.country.Text = "Gabon"; a = 60;
            }
            else if (R == 61)
            {
                this.country.Text = "Gambia"; a = 61;
            }
            else if (R == 62)
            {
                this.country.Text = "Georgia"; a = 62;
            }
            else if (R == 63)
            {
                this.country.Text = "Germany"; a = 63;
            }
            else if (R == 64)
            {
                this.country.Text = "Ghana"; a = 64;
            }
            else if (R == 65)
            {
                this.country.Text = "Greece"; a = 65;
            }
            else if (R == 66)
            {
                this.country.Text = "Grenada"; a = 66;
            }
            else if (R == 67)
            {
                this.country.Text = "Guatemala"; a = 67;
            }
            else if (R == 68)
            {
                this.country.Text = "Guinea"; a = 68;
            }
            else if (R == 69)
            {
                this.country.Text = "Guinea-Bissau"; a = 69;
            }
            else if (R == 70)
            {
                this.country.Text = "Guyana"; a = 70;
            }
            else if (R == 71)
            {
                this.country.Text = "Haiti"; a = 71;
            }
            else if (R == 72)
            {
                this.country.Text = "Honduras"; a = 72;
            }
            else if (R == 73)
            {
                this.country.Text = "Hungary"; a = 73;
            }
            else if (R == 74)
            {
                this.country.Text = "Iceland"; a = 74;
            }
            else if (R == 75)
            {
                this.country.Text = "India"; a = 75;
            }
            else if (R == 76)
            {
                this.country.Text = "Indonesia"; a = 76;
            }
            else if (R == 77)
            {
                this.country.Text = "Iran"; a = 77;
            }
            else if (R == 78)
            {
                this.country.Text = "Iraq"; a = 78;
            }
            else if (R == 79)
            {
                this.country.Text = "Ireland"; a = 79;
            }
            else if (R == 80)
            {
                this.country.Text = "Israel"; a = 80;
            }
            else if (R == 81)
            {
                this.country.Text = "Italy"; a = 81;
            }
            else if (R == 82)
            {
                this.country.Text = "Jamaica"; a = 82;
            }
            else if (R == 83)
            {
                this.country.Text = "Japan"; a = 83;
            }
            else if (R == 84)
            {
                this.country.Text = "Jordan"; a = 84;
            }
            else if (R == 85)
            {
                this.country.Text = "Kazakhstan"; a = 85;
            }
            else if (R == 86)
            {
                this.country.Text = "Kenya"; a = 86;
            }
            else if (R == 87)
            {
                this.country.Text = "Kiribati"; a = 87;
            }
            else if (R == 88)
            {
                this.country.Text = "North Korea"; a = 88;
            }
            else if (R == 89)
            {
                this.country.Text = "South Korea"; a = 89;
            }
            else if (R == 90)
            {
                this.country.Text = "Kosovo"; a = 90;
            }
            else if (R == 91)
            {
                this.country.Text = "Kuwait"; a = 91;
            }
            else if (R == 92)
            {
                this.country.Text = "Kygryzstan"; a = 92;
            }
            else if (R == 93)
            {
                this.country.Text = "Laos"; a = 93;
            }
            else if (R == 94)
            {
                this.country.Text = "Latvia"; a = 94;
            }
            else if (R == 95)
            {
                this.country.Text = "Lebanon"; a = 95;
            }
            else if (R == 96)
            {
                this.country.Text = "Lesotho"; a = 96;
            }
            else if (R == 97)
            {
                this.country.Text = "Liberia"; a = 97;
            }
            else if (R == 98)
            {
                this.country.Text = "Libya"; a = 98;
            }
            else if (R == 99)
            {
                this.country.Text = "Liechtenstein"; a = 99;
            }
            else if (R == 100)
            {
                this.country.Text = "Lithuania"; a = 100;
            }
            else if (R == 101)
            {
                this.country.Text = "Luxembourg"; a = 101;
            }
            else if (R == 102)
            {
                this.country.Text = "Madagascar"; a = 102;
            }
            else if (R == 103)
            {
                this.country.Text = "Malawi"; a = 103;
            }
            else if (R == 104)
            {
                this.country.Text = "Malaysia"; a = 104;
            }
            else if (R == 105)
            {
                this.country.Text = "Maldives"; a = 105;
            }
            else if (R == 106)
            {
                this.country.Text = "Mali"; a = 106;
            }
            else if (R == 107)
            {
                this.country.Text = "Malta"; a = 107;
            }
            else if (R == 108)
            {
                this.country.Text = "Marshall Islands"; a = 108;
            }
            else if (R == 109)
            {
                this.country.Text = "Mauritania"; a = 109;
            }
            else if (R == 110)
            {
                this.country.Text = "Mauritius"; a = 110;
            }
            else if (R == 111)
            {
                this.country.Text = "Mexico"; a = 111;
            }
            else if (R == 112)
            {
                this.country.Text = "Micronesia"; a = 112;
            }
            else if (R == 113)
            {
                this.country.Text = "Moldova"; a = 113;
            }
            else if (R == 114)
            {
                this.country.Text = "Monaco"; a = 114;
            }
            else if (R == 115)
            {
                this.country.Text = "Mongolia"; a = 115;
            }
            else if (R == 116)
            {
                this.country.Text = "Montenegro"; a = 116;
            }
            else if (R == 117)
            {
                this.country.Text = "Morocco"; a = 117;
            }
            else if (R == 118)
            {
                this.country.Text = "Mozambique"; a = 118;
            }
            else if (R == 119)
            {
                this.country.Text = "Myanmar"; a = 119;
            }
            else if (R == 120)
            {
                this.country.Text = "Namibia"; a = 120;
            }
            else if (R == 121)
            {
                this.country.Text = "Nauru"; a = 121;
            }
            else if (R == 122)
            {
                this.country.Text = "Nepal"; a = 122;
            }
            else if (R == 123)
            {
                this.country.Text = "Netherlands"; a = 123;
            }
            else if (R == 124)
            {
                this.country.Text = "New Zealand"; a = 124;
            }
            else if (R == 125)
            {
                this.country.Text = "Nicaragua"; a = 125;
            }
            else if (R == 126)
            {
                this.country.Text = "Niger"; a = 126;
            }
            else if (R == 127)
            {
                this.country.Text = "Nigeria"; a = 127;
            }
            else if (R == 128)
            {
                this.country.Text = "North Macedonia"; a = 128;
            }
            else if (R == 129)
            {
                this.country.Text = "Norway"; a = 129;
            }
            else if (R == 130)
            {
                this.country.Text = "Oman"; a = 130;
            }
            else if (R == 131)
            {
                this.country.Text = "Pakistan"; a = 131;
            }
            else if (R == 132)
            {
                this.country.Text = "Palau"; a = 132;
            }
            else if (R == 133)
            {
                this.country.Text = "Palestine"; a = 133;
            }
            else if (R == 134)
            {
                this.country.Text = "Panama"; a = 134;
            }
            else if (R == 135)
            {
                this.country.Text = "Papua New Guinea"; a = 135;
            }
            else if (R == 136)
            {
                this.country.Text = "Paraguay"; a = 136;
            }
            else if (R == 137)
            {
                this.country.Text = "Peru"; a = 137;
            }
            else if (R == 138)
            {
                this.country.Text = "Philippines"; a = 138;
            }
            else if (R == 139)
            {
                this.country.Text = "Poland"; a = 139;
            }
            else if (R == 140)
            {
                this.country.Text = "Portugal"; a = 140;
            }
            else if (R == 141)
            {
                this.country.Text = "Qatar"; a = 141;
            }
            else if (R == 142)
            {
                this.country.Text = "Romania"; a = 142;
            }
            else if (R == 143)
            {
                this.country.Text = "Russia"; a = 143;
            }
            else if (R == 144)
            {
                this.country.Text = "Rwanda"; a = 144;
            }
            else if (R == 145)
            {
                this.country.Text = "Samoa"; a = 145;
            }
            else if (R == 146)
            {
                this.country.Text = "San Marino"; a = 146;
            }
            else if (R == 147)
            {
                this.country.Text = "Sao Tome and Principe"; a = 147;
            }
            else if (R == 148)
            {
                this.country.Text = "Saudi Arabia"; a = 148;
            }
            else if (R == 149)
            {
                this.country.Text = "Senegal"; a = 149;
            }
            else if (R == 150)
            {
                this.country.Text = "Serbia"; a = 150;
            }
            else if (R == 151)
            {
                this.country.Text = "Seychelles"; a = 151;
            }
            else if (R == 152)
            {
                this.country.Text = "Sierra Leone"; a = 152;
            }
            else if (R == 153)
            {
                this.country.Text = "Singapore"; a = 153;
            }
            else if (R == 154)
            {
                this.country.Text = "Slovakia"; a = 154;
            }
            else if (R == 155)
            {
                this.country.Text = "Slovenia"; a = 155;
            }
            else if (R == 156)
            {
                this.country.Text = "Solomon Islands"; a = 156;
            }
            else if (R == 157)
            {
                this.country.Text = "Somalia"; a = 157;
            }
            else if (R == 158)
            {
                this.country.Text = "South Africa"; a = 158;
            }
            else if (R == 159)
            {
                this.country.Text = "South Sudan"; a = 159;
            }
            else if (R == 160)
            {
                this.country.Text = "Spain"; a = 160;
            }
            else if (R == 161)
            {
                this.country.Text = "Sri Lanka"; a = 161;
            }
            else if (R == 162)
            {
                this.country.Text = "Saint Kitts and Nevis"; a = 162;
            }
            else if (R == 163)
            {
                this.country.Text = "Saint Lucia"; a = 163;
            }
            else if (R == 164)
            {
                this.country.Text = "Saint Vincent and the Grenadines"; a = 164;
            }
            else if (R == 165)
            {
                this.country.Text = "Sudan"; a = 165;
            }
            else if (R == 166)
            {
                this.country.Text = "Suriname"; a = 166;
            }
            else if (R == 167)
            {
                this.country.Text = "Sweden"; a = 167;
            }
            else if (R == 168)
            {
                this.country.Text = "Switzerland"; a = 168;
            }
            else if (R == 169)
            {
                this.country.Text = "Syria"; a = 169;
            }
            else if (R == 170)
            {
                this.country.Text = "Taiwan"; a = 170;
            }
            else if (R == 171)
            {
                this.country.Text = "Tajikistan"; a = 171;
            }
            else if (R == 172)
            {
                this.country.Text = "Tanzania"; a = 172;
            }
            else if (R == 173)
            {
                this.country.Text = "Thailand"; a = 173;
            }
            else if (R == 174)
            {
                this.country.Text = "Timor-Leste"; a = 174;
            }
            else if (R == 175)
            {
                this.country.Text = "Togo"; a = 175;
            }
            else if (R == 176)
            {
                this.country.Text = "Tonga"; a = 176;
            }
            else if (R == 177)
            {
                this.country.Text = "Trinidad and Tobago"; a = 177;
            }
            else if (R == 178)
            {
                this.country.Text = "Tunisia"; a = 178;
            }
            else if (R == 179)
            {
                this.country.Text = "Turkey"; a = 179;
            }
            else if (R == 180)
            {
                this.country.Text = "Turkmenistan"; a = 180;
            }
            else if (R == 181)
            {
                this.country.Text = "Tuvalu"; a = 181;
            }
            else if (R == 182)
            {
                this.country.Text = "Uganda"; a = 182;
            }
            else if (R == 183)
            {
                this.country.Text = "Ukraine"; a = 183;
            }
            else if (R == 184)
            {
                this.country.Text = "United Arab Emirates"; a = 184;
            }
            else if (R == 185)
            {
                this.country.Text = "United Kingdom"; a = 185;
            }
            else if (R == 186)
            {
                this.country.Text = "United States of America"; a = 186;
            }
            else if (R == 187)
            {
                this.country.Text = "Uruguay"; a = 187;
            }
            else if (R == 188)
            {
                this.country.Text = "Uzbekistan"; a = 188;
            }
            else if (R == 189)
            {
                this.country.Text = "Vanuatu"; a = 189;
            }
            else if (R == 190)
            {
                this.country.Text = "Vatican City"; a = 190;
            }
            else if (R == 191)
            {
                this.country.Text = "Venezuela"; a = 191;
            }
            else if (R == 192)
            {
                this.country.Text = "Vietnam"; a = 192;
            }
            else if (R == 193)
            {
                this.country.Text = "Yemen"; a = 193;
            }
            else if (R == 194)
            {
                this.country.Text = "Zambia"; a = 194;
            }
            else if (R == 195)
            {
                this.country.Text = "Zimbabwe"; a = 195;
            }
            else if (R == 196)
            {
                this.country.Text = "Belgium"; a = 196;
            }
            else if (R == 197)
            {
                this.country.Text = "Afghanistan"; a = 197;
            }
        }

        private void check_awnser()
        {
            string c = country.Text;
            string a = textBox1.Text;
            string b = country.Text;
            if (a == b)
            {
                country.ForeColor = Color.Green;
                country.Text = "Correct!";
            }
            else if (a != b)
            {
                CorAwnser.ForeColor = Color.Red;
                CorAwnser.Text = ("The correct awnser is : " + c);
                country.ForeColor = Color.Red;
                country.Text = "Incorrect!";
            }
        }
    }
}

