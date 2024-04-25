using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yhteenlasku_funktio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luku1 = 4, luku2 = 5;
            int tulos;
            tulos = LaskeYhteen(luku1, luku2);
            Console.WriteLine(tulos);
            Console.ReadKey();
        }
        static int LaskeYhteen(int a, int b)
        {
            int summa;
            summa = a + b;
            return summa;
        }
    }
}
