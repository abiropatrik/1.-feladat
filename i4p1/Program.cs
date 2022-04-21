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

            char[] kulcskarakterek = kulcs.ToCharArray();

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
