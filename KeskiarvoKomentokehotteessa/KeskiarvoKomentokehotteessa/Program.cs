﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeskiarvoKomentokehotteessa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double summa, keskiarvo;
            summa = 0;
            foreach (string luvut in args)
            {
                summa = summa + double.Parse(luvut);
            }
            keskiarvo = summa / args.Count();
            Console.WriteLine("Lukujen keskiarvo on " + keskiarvo);
            Console.ReadKey();
        }
    }
}
