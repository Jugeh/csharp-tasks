string teksti;

Console.WriteLine("Kirjoita teksti: ");
teksti = Console.ReadLine();

Console.WriteLine(teksti.Length);
Console.WriteLine(teksti[0]);
Console.WriteLine(teksti.EndsWith("lu"));
Console.WriteLine(teksti.Contains("ie"));
Console.WriteLine(teksti.IndexOf("p"));
Console.WriteLine(teksti.Trim());
Console.WriteLine(teksti.Replace('r', 'l'));
Console.WriteLine(teksti.PadLeft(30));

Console.ReadKey();