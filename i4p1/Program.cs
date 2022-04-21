using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i4p1
{
    class Program
    {
        public static string Feladat1a(string uzenet, string kulcs)
        {
            char[] uzenetkarakterek = uzenet.ToCharArray();
            int[] uzenetkod = new int[uzenetkarakterek.Length];


            char[] kulcskarakterek = kulcs.ToCharArray();
            int[] kulcskod = new int[kulcskarakterek.Length];

            char a = 'a';

            int[] megoldaskod = new int[uzenet.Length];
            char[] megoldaskarakterek = new char[uzenet.Length];

            for (int i = 0; i < uzenetkarakterek.Length; i++)
            {
                if (uzenetkarakterek[i].Equals(' '))
                {
                    uzenetkod[i] = 26;
                }
                else
                {
                    uzenetkod[i] = uzenetkarakterek[i] - a;
                }
                if (kulcskarakterek[i].Equals(' '))
                {
                    kulcskod[i] = 26;
                }
                else
                {
                    kulcskod[i] = kulcskarakterek[i] - a;
                }
                megoldaskod[i] = kulcskod[i] + uzenetkod[i];
            }
            return "0";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg az üzenetet: ");
            string uzenet = Console.ReadLine();
            Console.WriteLine("Adja meg a kulcsot: ");
            string kulcs = Console.ReadLine();

            Console.ReadKey();
        }
    }
}
