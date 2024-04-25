using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piste
{
    class PointTest
    {
        static void Main(string[] args)
        {
            Point startingPoint = new Point(3, 4);
            Console.WriteLine(startingPoint.GetX() + ", " + startingPoint.GetY());
            startingPoint.SetX(6);
            startingPoint.SetY(9);
            Console.WriteLine(startingPoint.GetX() + ", " + startingPoint.GetY());

            Console.ReadKey();
        }
    }
}
