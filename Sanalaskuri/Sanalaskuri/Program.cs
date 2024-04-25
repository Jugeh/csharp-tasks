using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanalaskuri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader file = new StreamReader("sanoja.txt"))
            {
                string rivi;
                int laskuri = 0;
                do
                {
                    rivi = file.ReadLine();
                    if (rivi != null)
                    {
                        laskuri += rivi.Split(' ').Length;
                    }
                }
                while (rivi != null);
                Console.WriteLine(laskuri);
                Console.ReadKey();
            }
        }
    }
}
