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
            Point uusiPiste = new Point(2, 3);
            //määritetään ympyrälle säde ja lisätään koordinaatit siihen
            Ympyra ympyranMitat = new Ympyra(3.0, uusiPiste);
            //tulostetaan ympyrän pinta-ala
            Console.WriteLine("Ympyrän pinta-ala: " + ympyranMitat.Pintaala);

            Console.ReadKey();
        }
    }
}
