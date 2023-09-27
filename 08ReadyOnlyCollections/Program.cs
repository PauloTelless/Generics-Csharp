using System.Collections.ObjectModel;

var planetas = new List<string>()
{
    "Mercúrio",
    "Vênus",
    "Terra",
    "Marte",
};

var ListaPlanetaImutavel = new ReadOnlyCollection<string>(planetas);

Console.WriteLine("Para lermos a coleção, usamos o foreach");

foreach (var planet in planetas)
{
    Console.WriteLine(planet);
}

Console.WriteLine("Para verificar se existe um item na coleção:");
Console.WriteLine($"Netuno estar na coleção ? {ListaPlanetaImutavel.Contains("Netuno")}");

Console.WriteLine($"Planeta de índice 3: {ListaPlanetaImutavel[3]}");

Console.WriteLine("Podemos usar o método IndexOf para encontrar o índice do elemento");
Console.WriteLine($"Índice de Terra => {ListaPlanetaImutavel.IndexOf("Terra")}");

Console.WriteLine("Tudo que for adicionado a lista principal, será refletida na lista de leitura");
Console.WriteLine("Adicionando Netuno no índice 4 da lista principal...");
planetas.Insert(4, "Netuno");
Console.WriteLine($"Netuno estar na coleção ? {ListaPlanetaImutavel.Contains("Netuno")}");
foreach (var planet in planetas)
{
    Console.WriteLine(planet);
}
