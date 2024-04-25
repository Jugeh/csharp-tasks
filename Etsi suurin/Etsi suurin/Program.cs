int luku1, luku2, luku3;

Console.WriteLine("Anna luku: ");
luku1 = int.Parse(Console.ReadLine());

Console.WriteLine("Anna luku: ");
luku2 = int.Parse(Console.ReadLine());

Console.WriteLine("Anna luku: ");
luku3 = int.Parse(Console.ReadLine());

Console.WriteLine(Math.Max(Math.Max(luku1, luku2), luku3));