double tulos, a, b, c, d;

Console.WriteLine("Anna a: ");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Anna b: ");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Anna c: ");
c = double.Parse(Console.ReadLine());

Console.WriteLine("Anna d: ");
d = double.Parse(Console.ReadLine());

tulos = (a - b) / (c * d);
Console.WriteLine("Tulos on " + tulos);
Console.ReadKey();