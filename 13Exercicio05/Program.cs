//Declare um método genérico chamado ReverterEImprimir em uma classe não genérica chamada
//Exemplo.
//O método recebe como parâmetro um array de qualquer tipo.
//A seguir declare três tipos diferentes de array : um array de int , um array de strings e um array de
//double
//Invoque o método duas vezes com cada array.
//Na primeira vez invoque o método com um determinado array, onde ele usa explicitamente o
//parâmetro de tipo.
//Na segunda vez, invoque o método onde o tipo é inferido.

int[] arrayInteiros = { 18, 40};
string[] arrayString = { "Paulo", "João" };
double[] arrayDouble = { 12.4, 24.1 };

Exemplo.ReverterEImprimir<int>(arrayInteiros); // => Método com o tipo implícito
Exemplo.ReverterEImprimir(arrayInteiros); // => Método com o tipo inferido

Exemplo.ReverterEImprimir<string>(arrayString); // => Método com o tipo implícito
Exemplo.ReverterEImprimir(arrayString); // => Método com o tipo inferido

Exemplo.ReverterEImprimir<double>(arrayDouble);  // => Método com o tipo implícito
Exemplo.ReverterEImprimir(arrayDouble); // => Método com o tipo inferido

class Exemplo
{
    public static void ReverterEImprimir<T>(T[] colecao)
    {
        foreach (T t in colecao) 
        {
            Console.WriteLine(t);
        }

        Console.WriteLine();
    }
}