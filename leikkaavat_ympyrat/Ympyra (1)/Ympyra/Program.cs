using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ympyra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //määritetään x ja y koordinaateille pisteet
            Point uusiPiste = new Point(8, 9);
            Point uusiPiste2 = new Point(1, 2);
            //määritetään ympyröille säde ja lisätään koordinaatit niihin
            Ympyra ympyra1 = new Ympyra(2.0, uusiPiste);
            Ympyra ympyra2 = new Ympyra(3.0, uusiPiste2);

            //Laskukaava koordinaattien etäisyyksille
            double valiMatka = Math.Sqrt((uusiPiste.X - uusiPiste2.X) * (uusiPiste.X - uusiPiste2.X)
                            + (uusiPiste.Y - uusiPiste2.Y) * (uusiPiste.Y - uusiPiste2.Y));

            if (valiMatka <= ympyra1.Sade - ympyra2.Sade)
            {
                Console.Write("Ympyrät ovat päällekkäin ja ympyrä 1 on isompi");
            }
            else if (valiMatka <= ympyra2.Sade - ympyra1.Sade)
            {
                Console.Write("Ympyrät ovat päällekkäin ja ympyrä 2 on isompi");
            }
            else if (valiMatka <= ympyra1.Sade + ympyra2.Sade)
            {
                Console.Write("Ympyrät ovat osittain toistensa päällä");
            }
            else
            {
                Console.Write("Ympyrät ovat täysin erillään");
            }

            Console.ReadKey();
        }
    }
}
