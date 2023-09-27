//Escreva um programa para adicionar dois números inteiros usando o conceito de Generics.


AdicionaNumeros<int> adicionaNumeros = new AdicionaNumeros<int>();
Console.WriteLine(adicionaNumeros.AdicionarNumeros(2, 3));

class AdicionaNumeros<T> where T : struct, IComparable, IConvertible, IFormattable // => restringindo mais ainda o tipo, fazendo com que o tipo T seja compativel com qualquer operação matemática
{
    public T AdicionarNumeros(T num1, T num2)
    {
        dynamic Num1 = num1; //O dynamic serve para que o compilador resolva em tempo de compilação
        dynamic Num2 = num2;

        return Num1 + Num2;
    }
   
}