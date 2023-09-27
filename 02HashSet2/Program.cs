var bandas = new HashSet<string>()
{
    "Pearl Jam",
    "U2",
    "The Police"
};

var cantores = new HashSet<string>()
{
    "Eddie Vader",
    "Sting",
    "Bono Vox",
    "Phill Collins"
};

var instrumentos = new HashSet<string>()
{
    "Baixo",
    "Microfone",
    "Guitarra"
};

var instrumentosPrincipais = new HashSet<string>()
{
    "Microfone",
    "Guitarra",
    "Bateria",
    "Baixo",
    "Teclado"
};

var albuns = new HashSet<string>()
{
    "Regata Blanc",
    "Ten",
    "Pride"
};

var turne = new HashSet<string>() 
{
    "Ten",
    "Pride",
    "Regata Blanc"
};

//Adicionando um item em um hash set * Caso o não exista, retorna true e o item é adicionado.

if (!bandas.Contains("Genesis"))
{
    bandas.Add("Genesis");
}

//Verificando se uma coleção é subconjunto de outra

if (bandas.IsSubsetOf(cantores))
{
    Console.WriteLine("É um subconjunto");
}
else
{
    Console.WriteLine("Não é um subconjunto");
}

//Nesse caso, ele não seria um subconjunto, visto que nenhum item igual está presente em ambos os conjuntos

//Verificando se uma coleção é um superconjunto de outra: Instrumentos principais e instrumentos

if (instrumentosPrincipais.IsSupersetOf(instrumentos))
{
    Console.WriteLine("É um super conjunto");
}
else
{
    Console.WriteLine("Não é um super conjunto");
}

//Nesse caso, essa coleção seria um super cojunto, visto que a coleção "instrumentos principais", apresenta todos os itens da coleção "instrumentos"

//Determinando se um conjunto compartilha elementos com outro conjunto

if (bandas.Overlaps(cantores))
{
    Console.WriteLine("O conjunto compartilha elementos com o outro conjunto");
}
else
{
    Console.WriteLine("O conjunto não compartilha elementos do outro conjunto");
}

//Nesse caso, o conjunto não compartilha nenhum elemento com  o conjunto "cantores"

//Determinando se dois conjuntos contém os mesmos elementos

if (albuns.SetEquals(turne))
{
    Console.WriteLine("Compartilham os mesmos elementos");
}
else
{
    Console.WriteLine("Não compartilham os mesmos elementos");
}

Console.WriteLine("Juntando os cantores com as bandas");

bandas.UnionWith(cantores);

foreach (var band in bandas)
{
    Console.Write($"{band}, ");
};
Console.WriteLine();

Console.WriteLine("Apresentado a interseção de instrumentos");

instrumentos.IntersectWith(instrumentosPrincipais);

foreach (var itens in instrumentos)
{
    Console.WriteLine(itens);
}

Console.WriteLine("Apresentando a diferença entre dois conjuntos");
instrumentosPrincipais.ExceptWith(instrumentos);

foreach (var item in instrumentosPrincipais)
{
    Console.WriteLine(item);
}

Console.WriteLine("Elementos que não são comuns ao dois conjuntos");

cantores.SymmetricExceptWith(bandas);

foreach (var item in cantores)
{
    Console.WriteLine(item);
}