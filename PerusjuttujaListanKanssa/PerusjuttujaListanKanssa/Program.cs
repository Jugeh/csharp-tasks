using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerusjuttujaListanKanssa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lukuLista;

            lukuLista = new List<int>();

            lukuLista.Add(1);
            lukuLista.Add(5);
            lukuLista.Add(10);
            lukuLista.Add(15);
            lukuLista.Add(20);

            Console.WriteLine(lukuLista.Count);
            Console.WriteLine(lukuLista[2]);
            Console.WriteLine(lukuLista[4] = 100);
            lukuLista.AddRange(new int[] { 32, 0 });

            foreach (int luku in lukuLista)
            {
                Console.Write(luku + " ");
            }
            Console.WriteLine();

            Console.WriteLine(lukuLista.Contains(5));
            Console.WriteLine(lukuLista.Contains(10));
            foreach (int luku in lukuLista)
            {
                if (luku > 20)
                    Console.Write(luku + " ");
            }
            Console.WriteLine();

            lukuLista.Insert(0, 7);
            foreach (int luku in lukuLista)
            {
                Console.Write(luku + " ");
            }
            Console.WriteLine();

            lukuLista.RemoveAll(x => x > 10);

            foreach (int luku in lukuLista)
            {
                Console.Write(luku + " ");
            }
            Console.WriteLine();

            lukuLista.RemoveAt(1);

            foreach (int luku in lukuLista)
            {
                Console.Write(luku + " ");
            }

            Console.ReadKey();
        }
    }
}
