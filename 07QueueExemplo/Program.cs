using _07QueueExemplo;
using System.Collections;

Queue<Pedido> filaPedidos = new Queue<Pedido>();

filaPedidos.Enqueue(new Pedido(15354, 23.5));
filaPedidos.Enqueue(new Pedido(47766, 12.5));
filaPedidos.Enqueue(new Pedido(87864, 20.8));
filaPedidos.Enqueue(new Pedido(51367, 15.5));
filaPedidos.Enqueue(new Pedido(54647, 16.4));
Console.WriteLine($"Números de pedido na fila: {filaPedidos.Count()}");

//Processamento dos pedidos

Console.WriteLine("Ordem de pedidos");

Exibir(filaPedidos);

filaPedidos.Enqueue(new Pedido(65523, 18.30));
filaPedidos.Enqueue(new Pedido(24252, 19.20));

Console.WriteLine($"Números de pedido na fila: {filaPedidos.Count()}");

Exibir(filaPedidos);



static void Exibir(Queue<Pedido> filaPedidos)
{
    while (filaPedidos.Count > 0)
    {
        Pedido proximoPedido = filaPedidos.Dequeue();
        Console.WriteLine($"N° Pedido: {proximoPedido.NumeroPedido}\nValor: {proximoPedido.Valor:C}");
        Console.WriteLine();
    }
}