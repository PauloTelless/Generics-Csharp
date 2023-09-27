//Implementar um programa que simula uma fila de impressão seguindo o seguinte roteiro:
//• Crie uma variável do tipo Queue<string> para representar a fila de impressão.
//• Crie um loop que irá executar até que a fila de impressão esteja vazia.
//• Dentro do loop, verifique se a fila de impressão não está vazia. Se não estiver vazia, remova o primeiro
//elemento da fila usando o método Dequeue() e imprima na tela que o arquivo "X" está sendo impresso.
//• Simule o tempo de impressão com um Thread.Sleep() por um período aleatório de tempo entre 1 e 5
//segundos.
//• Após simular a impressão do arquivo, imprima na tela que o arquivo "X" foi impresso com sucesso.
//• Repita os passos 3 a 5 até que a fila de impressão esteja vazia.

Arquivo arquivo1 = new("documento.pdf"); //=> instanciando o arquivo
Arquivo arquivo2 = new("lista.jpg");
Arquivo arquivo3 = new("compras.png");

Arquivo.Imprimir(arquivo1);
Arquivo.Imprimir(arquivo2);
Arquivo.Imprimir(arquivo3);


class Arquivo
{
    public string? NomeArquivo { get; set; }
    public Arquivo(string? nomeArquivo)
    {
        NomeArquivo = nomeArquivo;
    }

    public  static void Imprimir(Arquivo arquivo)
    {
        Queue<string?> filaImpressao = new Queue<string?>(); //=> criando a fila
        filaImpressao.Enqueue(arquivo.NomeArquivo);

        while (filaImpressao.Count != 0)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"Imprimindo o arquivo: {arquivo.NomeArquivo}");
            filaImpressao.Dequeue(); //=> A cada arquivo impresso, um arquivo é excluído
            Thread.Sleep(new Random().Next(1000, 5000));
            Console.WriteLine($"{arquivo.NomeArquivo} impresso com sucesso !");
        }
    }
   
}