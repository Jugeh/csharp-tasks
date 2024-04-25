using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potenssiin_korotus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double luku1 = 0, luku2 = 5;
            double tulos;
            tulos = Potenssi(luku1, luku2);
            Console.WriteLine(tulos);

            Console.ReadKey();
        }
        static double Potenssi(double a, double b)
        {
            double vastaus;
            vastaus = Math.Pow(a, b);
            return vastaus;
        }

    }
}

