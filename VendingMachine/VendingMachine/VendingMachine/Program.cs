using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine automaatti = new VendingMachine(5, 1.25);

            Console.WriteLine(automaatti.BottlePrice);
            Console.WriteLine(automaatti.IsSoldOut());
            automaatti.BottlePrice = 2.10;
            Console.WriteLine(automaatti.BottlePrice);
            automaatti.InsertMoney(1.90);
            automaatti.InsertMoney(1);
            automaatti.AddBottles(2);
            Console.WriteLine(automaatti.BuyBottle());
            automaatti.InsertMoney(2.50);
            Console.WriteLine(automaatti.BuyBottle());
            automaatti.InsertMoney(10);
            Console.WriteLine(automaatti.BuyBottle());
            automaatti.InsertMoney(2.20);
            Console.WriteLine(automaatti.BuyBottle());
            automaatti.InsertMoney(2.40);
            Console.WriteLine(automaatti.BuyBottle());
            automaatti.InsertMoney(2.40);
            Console.WriteLine(automaatti.BuyBottle());
            automaatti.InsertMoney(3);
            Console.WriteLine(automaatti.BuyBottle());
            automaatti.InsertMoney(2.60);
            Console.WriteLine(automaatti.BuyBottle());
            automaatti.AddBottles(10);
            Console.WriteLine(automaatti.BuyBottle());
            Console.WriteLine("\nAutomaatin tiedot:");
            Console.WriteLine(automaatti);
            Console.WriteLine(automaatti.EmptyCashbox());
            Console.ReadKey();
        }
    }
}
