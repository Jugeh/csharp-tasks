using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolmeSuurinta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int syote;

            List<int> lukuLista;

            lukuLista = new List<int>();

            Console.WriteLine("Anna kokonaislukuja. Lopeta -1:llä");

            while (true)
            {
                Console.Write("Anna luku: ");
                syote = int.Parse(Console.ReadLine());

                lukuLista.Add(syote);

                if (syote == -1)
                {
                    Console.Write("Luvut: ");

                    foreach (int luku in lukuLista)
                    {
                        Console.Write(luku + " ");
                    }

                    Console.WriteLine();
                    IEnumerable<int> kolmeSuurinta =
                    lukuLista.OrderByDescending(luku => luku).Take(3);
                    Console.Write("Kolme suurinta ovat: ");

                    foreach (int luku in kolmeSuurinta)
                    {
                        Console.Write(luku + " ");

                    }

                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
