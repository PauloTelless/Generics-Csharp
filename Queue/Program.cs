Console.WriteLine("Introdução a fila");
Console.WriteLine("Para adicionar um item na fila, usamos o método Enqueue");
Queue<string> musicas =  new Queue<string>();

musicas.Enqueue("Toda cor");
musicas.Enqueue("Jesus he knows me");
musicas.Enqueue("Horse with no name");
musicas.Enqueue("Love it loud");
musicas.Enqueue("Smell like teens spirits");
musicas.Enqueue("Spirits in the material world");
musicas.Enqueue("Marvin");

Exibir(musicas);

Console.WriteLine();

Console.WriteLine("Para retornarmos um item da fila sem exclui-lo, usamos o método Peek");
Console.WriteLine($"Selecionando a música Marvin => {musicas.Peek()}");

Console.WriteLine();
Console.WriteLine("Para retornarmos um item e exclui-lo, usamos o método Dequeue");
Console.WriteLine("Toda cor sendo removida...");
musicas.Dequeue();

Exibir(musicas);

Console.WriteLine("Para verificar se existe um item na fila, usamos o método Contains");

Exibir(musicas);

Console.WriteLine($"A música Índios estar presente ? {musicas.Contains("Índios")}");

if (!musicas.Contains("Índios"))
{
    musicas.Enqueue("Índios");
}

Exibir(musicas);
Console.WriteLine($"A música Índios estar presente ? {musicas.Contains("Índios")}");
static void Exibir<T>(Queue<T> musicas)
{
    Console.WriteLine();
    foreach (var item in musicas)
    {
        Console.WriteLine(item);
    }
}