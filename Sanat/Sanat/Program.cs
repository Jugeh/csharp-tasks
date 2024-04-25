using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string sana in args)
            {
                Console.WriteLine(sana);
            }
            Console.ReadKey();
        }
    }
}
