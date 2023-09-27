var numeros = new SortedSet<int>() 
{
    1, 4, 2, 6, 3, 9, 5
};
Exibir(numeros);

var frutas = new SortedSet<string>()
{
    "banana",
    "maça",
    "kiwi",
    "limão",
    "melão"
};
Exibir(frutas);

var numerosPares = new SortedSet<int>() { };

for (int i = 0; i < 6; i++)
{
    numerosPares.Add(i * 2); 
}
Exibir(numerosPares);

var listaNumeros = new List<int>()
{
    23, 
    1,
    5,
    18,
    2,
    6,
    32,
    12,
    7
};

SortedSet<int> listaNumerosOrdenada = new SortedSet<int>(listaNumeros);
Exibir(listaNumerosOrdenada);

Console.WriteLine("Diante disso, percebemos que a coleção SortedSet<T> consegue ordernar os itens das coleções, mesmo que sejam declarados com uma instância de SortedSet<T>");
Console.ReadKey();
static void Exibir<T>(IEnumerable<T> colecao)
{
    foreach (var i in colecao)
    {
        Console.WriteLine(i);
    }
}