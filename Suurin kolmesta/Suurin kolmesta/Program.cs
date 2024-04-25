using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suurin_kolmesta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luku1 = 7, luku2 = 3, luku3 = 1;
            int tulos;
            tulos = SuurinKolmesta(luku1, luku2, luku3);
            Console.WriteLine(tulos);

            Console.ReadKey();
        }
        static int SuurinKolmesta(int a, int b, int c)
        {
            int vastaus;
            vastaus = Math.Max(Math.Max(a, b), c);
            return vastaus;
        }
    }
    }

