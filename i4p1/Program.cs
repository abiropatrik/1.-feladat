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
                if (kulcskod[i]+uzenetkod[i]>26)
                {
                    megoldaskod[i] = (kulcskod[i] + uzenetkod[i]) % 27;
                }
                megoldaskarakterek[i] = Convert.ToChar(megoldaskod[i] + a);
            }
            string megoldas = new string(megoldaskarakterek);
            return megoldas;
        }

        public static string Feladat1b(string kod, string kulcs)
        {

            char[] kodkarakterek = kod.ToCharArray();
            int[] kodkod = new int[kodkarakterek.Length];


            char[] kulcskarakterek = kulcs.ToCharArray();
            int[] kulcskod = new int[kulcskarakterek.Length];

            char a = 'a';

            int[] megoldaskod = new int[kod.Length];
            char[] megoldaskarakterek = new char[kod.Length];

            for (int i = 0; i < kodkarakterek.Length; i++)
            {
                if (kodkarakterek[i].Equals(' '))
                {
                    kodkod[i] = 26;
                }
                else
                {
                    kodkod[i] = kodkarakterek[i] - a;
                }
                if (kulcskarakterek[i].Equals(' '))
                {
                    kulcskod[i] = 26;
                }
                else
                {
                    kulcskod[i] = kulcskarakterek[i] - a;
                }
                megoldaskod[i] = kodkod[i]-kulcskod[i];
                if (kodkod[i]-kulcskod[i]<0)
                {
                    megoldaskod[i] = (kodkod[i]-kulcskod[i])*-26 % 27;
                }
                megoldaskarakterek[i] = Convert.ToChar(megoldaskod[i] + a);
            }
            string megoldas = new string(megoldaskarakterek);
            return megoldas;
        }

        static void Main(string[] args)
        {
            Console.Write("Adja meg az üzenetet: ");
            string uzenet = Console.ReadLine();
            Console.Write("Adja meg a kulcsot: ");
            string kulcs = Console.ReadLine();

            Console.WriteLine(Feladat1a(uzenet, kulcs));

            Console.ReadKey();
        }
    }
}
