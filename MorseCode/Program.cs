using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g',
                'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                's', 't', 'u', 'v', 'w', 'x', 'y', 'z','1','2','3','4','5',
                '6','7','8','9', '0'};

            string[] MorseLetters = { "    ", ". ___", "___ . . .", "___ . ___ .", "___ . .", ".", ". . ___ .", "___ ___ .",
            ". . . .", ". .", ". ___ ___ ___", "___ . ___", ". ___ . .", "___ ___", "___ .", "___ ___ ___", ". ___ ___ .",
            "___ ___ . ___", ". ___ .", ". . .", "___", ". . ___", ". . . ___", ". ___ ___", "___ . . ___", "___ . ___ ___",
            "___ ___ . .", ". ___ ___ ___ ___", ". . ___ ___ ___", ". . . ___ ___", ". . . . ___", ". . . . .", "___ . . . .",
            "___ ___ . . .", "___ ___ ___ . .", "___ ___ ___ ___ .", "___ ___ ___ ___ ___"};

            string TextOmTeVeranderen = "";
            string NieuweText = "";

            Console.WriteLine("Voer de text in die je wilt veranderen naar Morse");

            TextOmTeVeranderen = Console.ReadLine();
            TextOmTeVeranderen = TextOmTeVeranderen.ToLower();
            for (int i = 0; i < TextOmTeVeranderen.Length; i++)
            {
                for (short j = 0; j < 37; j++)
                {
                    if (TextOmTeVeranderen[i] == letters[j])
                    {
                        NieuweText += MorseLetters[j];
                        NieuweText += "    ";
                        break;
                    }
                }
            }

            Console.WriteLine("De in gevoerde text vertaald naar morse.");
            Console.WriteLine(NieuweText);

            Console.ReadKey();
        }
    }
}
