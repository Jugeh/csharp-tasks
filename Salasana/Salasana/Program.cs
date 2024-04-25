using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salasana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string salasana;

            do
            {
                Console.Write("Anna salasana: ");
                salasana = Console.ReadLine();
            }   while (salasana != "moppe");

            if (salasana == "moppe")
            {
                Console.WriteLine("Onnistui");
                Console.ReadKey();
            }

        }
    }
}
