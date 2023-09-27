var numeros = new HashSet<int>()
{ 
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};

var frutas = new HashSet<string>()
{
    "banana",
    "pêra",
    "uva",
    "limão"
};

var numerosPares = new HashSet<int>();

for (int i = 0; i < 5; i++)
{
    numerosPares.Add(i * 2);
}

foreach (var item in numerosPares)
{
    Console.WriteLine(item);
}

//Podemos adicionar outra coleção na coleção set

var lista = new List<int>()
{
    1,
    2,
    3,
    4
};

var listaHash = new HashSet<int>(lista);

//Pode ser feito o mesmo com um array ou outro conjunto que implementa a interface IEnumerable

var impares = new int[]
{
    1, 3, 5, 7, 9
};

var listaHashArray = new HashSet<int>(impares);