double ekaSivu, tokaSivu, tulos;

Console.WriteLine("Anna 1. sivun pituus: ");
ekaSivu = double.Parse(Console.ReadLine());

Console.WriteLine("Anna 2. sivun pituus: ");
tokaSivu = double.Parse(Console.ReadLine());

tulos = Math.Sqrt((ekaSivu * ekaSivu) + (tokaSivu * tokaSivu));
Console.WriteLine("Pitkän sivun pituus on " + tulos);
Console.ReadKey();
