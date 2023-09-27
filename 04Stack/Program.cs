Console.WriteLine("Introdução a pilhas");

Stack<string> pilhaJogos = new Stack<string>(); // => instanciando a pilha com o valor padrão

//Para adicionar um item na pilha, usamos o método "push"

pilhaJogos.Push("Grand Theft Auto V");
pilhaJogos.Push("CS:GO");
pilhaJogos.Push("Valorant");
pilhaJogos.Push("Free Fire");
pilhaJogos.Push("Fortnite");
pilhaJogos.Push("Pubg");
Exibir(pilhaJogos);
Console.WriteLine();

Console.WriteLine("O primeiro a ser adicionado foi \" Grand Theft Auto V\", mas ele vai para o final da pilha e o último a ser adicionado foi o \"Pubg\", mas é o primeiro da fila e vai ser o primeiro a sair");

Console.WriteLine();
Console.WriteLine("Para recuperarmos um item da pilha sem remove-lo, usamos o método Peek");
Console.WriteLine($"Foi selecionado {pilhaJogos.Peek()}");
Exibir(pilhaJogos);

Console.WriteLine();
Console.WriteLine("Para recuperarmos um item e remove-lo, usamos o método Pop");
Console.WriteLine($"Foi removido o item {pilhaJogos.Pop()}");
Exibir(pilhaJogos);

Console.WriteLine();
Console.WriteLine("Para saber se existe algum item na pilha, usamos o método Contains");
Console.WriteLine($"O item Valorant estar presente na pilha ? {pilhaJogos.Contains("Valorant")}");
Console.WriteLine($"O item Lol estar presente na pilha ? {pilhaJogos.Contains("Lol")}");
 
Console.WriteLine();
Console.WriteLine("Para fazermos uma cópia da pilha, podemos usar o método toArray e salva-la em outra variável");
var copy = new Stack<string>(pilhaJogos.ToArray());

Exibir(copy);

Console.WriteLine();
Console.WriteLine("Para remover todos itens da pilha, usamos o método Clear");
pilhaJogos.Clear();
Console.WriteLine($"{pilhaJogos.Count()} itens");


static void Exibir<T>(Stack<T> pilha)
{
    Console.WriteLine();
    foreach (var item in pilha)
    {
        Console.WriteLine(item);
    }
}