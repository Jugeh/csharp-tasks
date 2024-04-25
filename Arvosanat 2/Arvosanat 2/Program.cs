using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvosanat_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pisteet;

            do
            {
                Console.WriteLine("Anna pisteet: ");
                pisteet = int.Parse(Console.ReadLine());

            if (pisteet >= 0 && pisteet < 31)
            {
                Console.WriteLine("Arvosana on 0");
            }

            else if (pisteet > 30 && pisteet < 41)
            {
                Console.WriteLine("Arvosana on 4");
            }

            else if (pisteet > 40 && pisteet < 51)
            {
                Console.WriteLine("Arvosana on 5");
            }

            else if (pisteet > 50 && pisteet < 61)
            {
                Console.WriteLine("Arvosana on 6");
            }

            else if (pisteet > 60 && pisteet < 71)
            {
                Console.WriteLine("Arvosana on 7");
            }

            else if (pisteet > 70 && pisteet < 81)
            {
                Console.WriteLine("Arvosana on 8");
            }

            else if (pisteet > 80 && pisteet < 91)
            {
                Console.WriteLine("Arvosana on 9");
            }

            else if (pisteet > 90 && pisteet < 101)
            {
                Console.WriteLine("Arvosana on 10");
            }

            else if (pisteet > 100 || pisteet < -1)
            {
                Console.WriteLine("Pistemäärän pitää olla välillä 0 - 100.");
            }

            else
            {
                Console.WriteLine("Lopetetaan.");
                Console.ReadKey();
            }

            } while (pisteet != -1);
        }
    }
}
