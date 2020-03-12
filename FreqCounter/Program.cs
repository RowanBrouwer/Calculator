using System;
using System.IO;
using System.Linq;

namespace FreqCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] c = new int[(int)char.MaxValue];
            string s = File.ReadAllText("MyFile.txt");
            foreach (char t in s)
            {
                c[(int)t]++;
            }
            for (int i = 0; i < char.MaxValue; i++)
            {
                if (c[i] > 0 && char.IsLetterOrDigit((char)i))
                {
                    Console.WriteLine("Letter: {0} Frequency: {1}", (char)i, c[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
