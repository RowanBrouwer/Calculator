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

            Random r = new Random();
            int R = r.Next(1, 197);
            string path = @"C:\Users\Rowan\Desktop\Important\Flags\";
            pictureBox1.Image = Image.FromFile(path + R.ToString() + ".png");
            if (R == 1)
            {
                this.country.Text = "Albania";
            }
            else if (R == 2)
            {
                this.country.Text = "Algeria";

            }
            else if (R == 3)
            {
                this.country.Text = "Andorra";

            }
            else if (R == 4)
            {
                this.country.Text = "Angola";
            }
            else if (R == 5)
            {
                this.country.Text = "Antigua and Barbuda";
            }
            else if (R == 6)
            {
                this.country.Text = "Argentina";
            }
            else if (R == 7)
            {
                this.country.Text = "Armenia";
            }
            else if (R == 8)
            {
                this.country.Text = "Australia";
            }
            else if (R == 9)
            {
                this.country.Text = "Austria";
            }
            else if (R == 10)
            {
                this.country.Text = "Azerbaijan";
            }
            else if (R == 11)
            {
                this.country.Text = "Bahamas";
            }
            else if (R == 12)
            {
                this.country.Text = "Bahrain";
            }
            else if (R == 13)
            {
                this.country.Text = "Bangladesh";
            }
            else if (R == 14)
            {
                this.country.Text = "Barbados";
            }
            else if (R == 15)
            {
                this.country.Text = "Belarus";
            }
            else if (R == 16)
            {
                this.country.Text = "Belize";
            }
            else if (R == 17)
            {
                this.country.Text = "Benin";
            }
            else if (R == 18)
            {
                this.country.Text = "Bhutan";
            }
            else if (R == 19)
            {
                this.country.Text = "Bolivia";
            }
            else if (R == 20)
            {
                this.country.Text = "Bosnia and Herzegovina";
            }
            else if (R == 21)
            {
                this.country.Text = "Botswana";
            }
            else if (R == 22)
            {
                this.country.Text = "Brazil";
            }
            else if (R == 23)
            {
                this.country.Text = "Brunei";
            }
            else if (R == 24)
            {
                this.country.Text = "Bulgaria";
            }
            else if (R == 25)
            {
                this.country.Text = "Burkina Faso";
            }
            else if (R == 26)
            {
                this.country.Text = "Burundi";
            }
            else if (R == 27)
            {
                this.country.Text = "Cabo Verde";
            }
            else if (R == 28)
            {
                this.country.Text = "Cambodia";
            }
            else if (R == 29)
            {
                this.country.Text = "Cameroon";
            }
            else if (R == 30)
            {
                this.country.Text = "Canada";
            }
            else if (R == 31)
            {
                this.country.Text = "Central African Republic";
            }
            else if (R == 32)
            {
                this.country.Text = "Chad";
            }
            else if (R == 33)
            {
                this.country.Text = "Chile";
            }
            else if (R == 34)
            {
                this.country.Text = "China";
            }
            else if (R == 35)
            {
                this.country.Text = "Colombia";
            }
            else if (R == 36)
            {
                this.country.Text = "Comoros";
            }
            else if (R == 37)
            {
                this.country.Text = "Republic of the Congo";
            }
            else if (R == 38)
            {
                this.country.Text = "Democratic Republic of the Congo";
            }
            else if (R == 39)
            {
                this.country.Text = "Costa Rica";
            }
            else if (R == 40)
            {
                this.country.Text = "Cote d'Ivoire";
            }
            else if (R == 41)
            {
                this.country.Text = "Croatia";
            }
            else if (R == 42)
            {
                this.country.Text = "Cuba";
            }
            else if (R == 43)
            {
                this.country.Text = "Cyprus";
            }
            else if (R == 44)
            {
                this.country.Text = "Czechia";
            }
            else if (R == 45)
            {
                this.country.Text = "Denmark";
            }
            else if (R == 46)
            {
                this.country.Text = "Djibouti";
            }
            else if (R == 47)
            {
                this.country.Text = "Dominica";
            }
            else if (R == 48)
            {
                this.country.Text = "Dominican Republic";
            }
            else if (R == 49)
            {
                this.country.Text = "Ecuador";
            }
            else if (R == 50)
            {
                this.country.Text = "Egypt";
            }
            else if (R == 51)
            {
                this.country.Text = "El Salvador";
            }
            else if (R == 52)
            {
                this.country.Text = "Equitorial Guinea";
            }
            else if (R == 53)
            {
                this.country.Text = "Eritrea";
            }
            else if (R == 54)
            {
                this.country.Text = "Estonia";
            }
            else if (R == 55)
            {
                this.country.Text = "Eswatini";
            }
            else if (R == 56)
            {
                this.country.Text = "Ethiopia";
            }
            else if (R == 57)
            {
                this.country.Text = "Fiji";
            }
            else if (R == 58)
            {
                this.country.Text = "Finland";
            }
            else if (R == 59)
            {
                this.country.Text = "France";
            }
            else if (R == 60)
            {
                this.country.Text = "Gabon";
            }
            else if (R == 61)
            {
                this.country.Text = "Gambia";
            }
            else if (R == 62)
            {
                this.country.Text = "Georgia";
            }
            else if (R == 63)
            {
                this.country.Text = "Germany";
            }
            else if (R == 64)
            {
                this.country.Text = "Ghana";
            }
            else if (R == 65)
            {
                this.country.Text = "Greece";
            }
            else if (R == 66)
            {
                this.country.Text = "Grenada";
            }
            else if (R == 67)
            {
                this.country.Text = "Guatemala";
            }
            else if (R == 68)
            {
                this.country.Text = "Guinea";
            }
            else if (R == 69)
            {
                this.country.Text = "Guinea-Bissau";
            }
            else if (R == 70)
            {
                this.country.Text = "Guyana";
            }
            else if (R == 71)
            {
                this.country.Text = "Haiti";
            }
            else if (R == 72)
            {
                this.country.Text = "Honduras";
            }
            else if (R == 73)
            {
                this.country.Text = "Hungary";
            }
            else if (R == 74)
            {
                this.country.Text = "Iceland";
            }
            else if (R == 75)
            {
                this.country.Text = "India";
            }
            else if (R == 76)
            {
                this.country.Text = "Indonesia";
            }
            else if (R == 77)
            {
                this.country.Text = "Iran";
            }
            else if (R == 78)
            {
                this.country.Text = "Iraq";
            }
            else if (R == 79)
            {
                this.country.Text = "Ireland";
            }
            else if (R == 80)
            {
                this.country.Text = "Israel";
            }
            else if (R == 81)
            {
                this.country.Text = "Italy";
            }
            else if (R == 82)
            {
                this.country.Text = "Jamaica";
            }
            else if (R == 83)
            {
                this.country.Text = "Japan";
            }
            else if (R == 84)
            {
                this.country.Text = "Jordan";
            }
            else if (R == 85)
            {
                this.country.Text = "Kazakhstan";
            }
            else if (R == 86)
            {
                this.country.Text = "Kenya";
            }
            else if (R == 87)
            {
                this.country.Text = "Kiribati";
            }
            else if (R == 88)
            {
                this.country.Text = "North Korea";
            }
            else if (R == 89)
            {
                this.country.Text = "South Korea";
            }
            else if (R == 90)
            {
                this.country.Text = "Kosovo";
            }
            else if (R == 91)
            {
                this.country.Text = "Kuwait";
            }
            else if (R == 92)
            {
                this.country.Text = "Kygryzstan";
            }
            else if (R == 93)
            {
                this.country.Text = "Laos";
            }
            else if (R == 94)
            {
                this.country.Text = "Latvia";
            }
            else if (R == 95)
            {
                this.country.Text = "Lebanon";
            }
            else if (R == 96)
            {
                this.country.Text = "Lesotho";
            }
            else if (R == 97)
            {
                this.country.Text = "Liberia";
            }
            else if (R == 98)
            {
                this.country.Text = "Libya";
            }
            else if (R == 99)
            {
                this.country.Text = "Liechtenstein";
            }
            else if (R == 100)
            {
                this.country.Text = "Lithuania";
            }
            else if (R == 101)
            {
                this.country.Text = "Luxembourg";
            }
            else if (R == 102)
            {
                this.country.Text = "Madagascar";
            }
            else if (R == 103)
            {
                this.country.Text = "Malawi";
            }
            else if (R == 104)
            {
                this.country.Text = "Malaysia";
            }
            else if (R == 105)
            {
                this.country.Text = "Maldives";
            }
            else if (R == 106)
            {
                this.country.Text = "Mali";
            }
            else if (R == 107)
            {
                this.country.Text = "Malta";
            }
            else if (R == 108)
            {
                this.country.Text = "Marshall Islands";
            }
            else if (R == 109)
            {
                this.country.Text = "Mauritania";
            }
            else if (R == 110)
            {
                this.country.Text = "Mauritius";
            }
            else if (R == 111)
            {
                this.country.Text = "Mexico";
            }
            else if (R == 112)
            {
                this.country.Text = "Micronesia";
            }
            else if (R == 113)
            {
                this.country.Text = "Moldova";
            }
            else if (R == 114)
            {
                this.country.Text = "Monaco";
            }
            else if (R == 115)
            {
                this.country.Text = "Mongolia";
            }
            else if (R == 116)
            {
                this.country.Text = "Montenegro";
            }
            else if (R == 117)
            {
                this.country.Text = "Morocco";
            }
            else if (R == 118)
            {
                this.country.Text = "Mozambique";
            }
            else if (R == 119)
            {
                this.country.Text = "Myanmar";
            }
            else if (R == 120)
            {
                this.country.Text = "Namibia";
            }
            else if (R == 121)
            {
                this.country.Text = "Nauru";
            }
            else if (R == 122)
            {
                this.country.Text = "Nepal";
            }
            else if (R == 123)
            {
                this.country.Text = "Netherlands";
            }
            else if (R == 124)
            {
                this.country.Text = "New Zealand";
            }
            else if (R == 125)
            {
                this.country.Text = "Nicaragua";
            }
            else if (R == 126)
            {
                this.country.Text = "Niger";
            }
            else if (R == 127)
            {
                this.country.Text = "Nigeria";
            } 
                    else if (R == 128)
                    {
                        this.country.Text = "North Macedonia";
                    }
                    else if (R == 129)
                    {
                        this.country.Text = "Norway";
                    }
                    else if (R == 130)
                    {
                        this.country.Text = "Oman";
                    }
                    else if (R == 131)
                    {
                        this.country.Text = "Pakistan";
                    }
                    else if (R == 132)
                    {
                        this.country.Text = "Palau";
                    }
                    else if (R == 133)
                    {
                        this.country.Text = "Palestine";
                    }
                    else if (R == 134)
                    {
                        this.country.Text = "Panama";
                    }
                    else if (R == 135)
                    {
                        this.country.Text = "Papua New Guinea";
                    }
                    else if (R == 136)
                    {
                        this.country.Text = "Paraguay";
                    }
                    else if (R == 137)
                    {
                        this.country.Text = "Peru";
                    }
                    else if (R == 138)
                    {
                        this.country.Text = "Philippines";
                    }
                    else if (R == 139)
                    {
                        this.country.Text = "Poland";
                    }
                    else if (R == 140)
                    {
                        this.country.Text = "Portugal";
                    }
                    else if (R == 141)
                    {
                        this.country.Text = "Qatar";
                    }
                    else if (R == 142)
                    {
                        this.country.Text = "Romania";
                    }
                    else if (R == 143)
                    {
                        this.country.Text = "Russia";
                    }
                    else if (R == 144)
                    {
                        this.country.Text = "Rwanda";
                    }
                    else if (R == 145)
                    {
                        this.country.Text = "Samoa";
                    }
                    else if (R == 146)
                    {
                        this.country.Text = "San Marino";
                    }
                    else if (R == 147)
                    {
                        this.country.Text = "Sao Tome and Principe";
                    }
                    else if (R == 148)
                    {
                        this.country.Text = "Saudi Arabia";
                    }
                    else if (R == 149)
                    {
                        this.country.Text = "Senegal";
                    }
                    else if (R == 150)
                    {
                        this.country.Text = "Serbia";
                    }
                    else if (R == 151)
                    {
                        this.country.Text = "Seychelles";
                    }
                    else if (R == 152)
                    {
                        this.country.Text = "Sierra Leone";
                    }
                    else if (R == 153)
                    {
                        this.country.Text = "Singapore";
                    }
                    else if (R == 154)
                    {
                        this.country.Text = "Slovakia";
                    }
                    else if (R == 155)
                    {
                        this.country.Text = "Slovenia";
                    }
                    else if (R == 156)
                    {
                        this.country.Text = "Solomon Islands";
                    }
                    else if (R == 157)
                    {
                        this.country.Text = "Somalia";
                    }
                    else if (R == 158)
                    {
                        this.country.Text = "South Africa";
                    }
                    else if (R == 159)
                    {
                        this.country.Text = "South Sudan";
                    }
                    else if (R == 160)
                    {
                        this.country.Text = "Spain";
                    }
                    else if (R == 161)
                    {
                        this.country.Text = "Sri Lanka";
                    }
                    else if (R == 162)
                    {
                        this.country.Text = "Saint Kitts and Nevis";
                    }
                    else if (R == 163)
                    {
                        this.country.Text = "Saint Lucia";
                    }
                    else if (R == 164)
                    {
                        this.country.Text = "Saint Vincent and the Grenadines";
                    }
                    else if (R == 165)
                    {
                        this.country.Text = "Sudan";
                    }
                    else if (R == 166)
                    {
                        this.country.Text = "Suriname";
                    }
                    else if (R == 167)
                    {
                        this.country.Text = "Sweden";
                    }
                    else if (R == 168)
                    {
                        this.country.Text = "Switzerland";
                    }
                    else if (R == 169)
                    {
                        this.country.Text = "Syria";
                    }
                    else if (R == 170)
                    {
                        this.country.Text = "Taiwan";
                    }
                    else if (R == 171)
                    {
                        this.country.Text = "Tajikistan";
                    }
                    else if (R == 172)
                    {
                        this.country.Text = "Tanzania";
                    }
                    else if (R == 173)
                    {
                        this.country.Text = "Thailand";
                    }
                    else if (R == 174)
                    {
                        this.country.Text = "Timor-Leste";
                    }
                    else if (R == 175)
                    {
                        this.country.Text = "Togo";
                    }
                    else if (R == 176)
                    {
                        this.country.Text = "Tonga";
                    }
                    else if (R == 177)
                    {
                        this.country.Text = "Trinidad and Tobago";
                    }
                    else if (R == 178)
                    {
                        this.country.Text = "Tunisia";
                    }
                    else if (R == 179)
                    {
                        this.country.Text = "Turkey";
                    }
                    else if (R == 180)
                    {
                        this.country.Text = "Turkmenistan";
                    }
                    else if (R == 181)
                    {
                        this.country.Text = "Tuvalu";
                    }
                    else if (R == 182)
                    {
                        this.country.Text = "Uganda";
                    }
                    else if (R == 183)
                    {
                        this.country.Text = "Ukraine";
                    }
                    else if (R == 184)
                    {
                        this.country.Text = "United Arab Emirates";
                    }
                    else if (R == 185)
                    {
                        this.country.Text = "United Kingdom";
                    }
                    else if (R == 186)
                    {
                        this.country.Text = "United States of America";
                    }
                    else if (R == 187)
                    {
                        this.country.Text = "Uruguay";
                    }
                    else if (R == 188)
                    {
                        this.country.Text = "Uzbekistan";
                    }
                    else if (R == 189)
                    {
                        this.country.Text = "Vanuatu";
                    }
                    else if (R == 190)
                    {
                        this.country.Text = "Vatican City";
                    }
                    else if (R == 191)
                    {
                        this.country.Text = "Venezuela";
                    }
                    else if (R == 192)
                    {
                        this.country.Text = "Vietnam";
                    }
                    else if (R == 193)
                    {
                        this.country.Text = "Yemen";
                    }
                    else if (R == 194)
                    {
                        this.country.Text = "Zambia";
                    }
                    else if (R == 195)
                    {
                        this.country.Text = "Zimbabwe";
                    }
                    else if (R == 196)
                    {
                        this.country.Text = "Belgium";
                    }
                    else if (R == 197)
                    {
                        this.country.Text = "Afghanistan";
                    }
        }
    }
}

