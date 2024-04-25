using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PisteOminaisuuksilla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Luodaan uudet luvut koordinaateille ja tulostetaan ne.
            Point startingPoint = new Point(3, 4);
            Console.WriteLine(startingPoint.X + ", " + startingPoint.Y);
            //Annetaan taas uudet luvut ja tulostetaan ne.
            startingPoint.X = 6;
            startingPoint.Y = 9;
            Console.WriteLine(startingPoint);

            Console.ReadKey();
        }
    }
}
