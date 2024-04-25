using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<int> omaLista = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                omaLista.Add(rnd.Next(0, 20));
            }
            foreach (int luku in omaLista)
            {
                Console.Write("{0} ", luku);
            }
            Console.WriteLine();
            //------------ Siirto alkaa
            int oikealtaTalteen = omaLista[omaLista.Count - 1];
            for (int i = omaLista.Count - 1; i > 0; i--)
            {
                omaLista[i] = omaLista[i - 1];
            }
            omaLista[0] = oikealtaTalteen;
            //------------ Siirto valmis
            foreach (int luku in omaLista)
            {
                Console.Write("{0} ", luku);
            }
            Console.WriteLine();

            var vasemmalle = omaLista[0];
            for (var i = 0; i < omaLista.Count - 1; i++)
            {
                omaLista[i] = omaLista[i + 1];
            }
            omaLista[omaLista.Count - 1] = vasemmalle;

            foreach (int luku in omaLista)
            {
                Console.Write("{0} ", luku);
            }

            Console.ReadKey();
        }
    }
}
