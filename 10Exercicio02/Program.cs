//Escreva um programa que crie uma lista de objetos Aluno que contém as propriedades : Nome,
//Idade e Sexo. A seguir defina 5 objetos do tipo Aluno e exiba uma lista de objetos alunos no console.

var listaAluno = new List<Aluno>
{
    new Aluno("Paulo", 19, "Masculino"), //=> objetos alunos na lista Aluno
    new Aluno("Grazi", 19, "Feminino"),
    new Aluno("Jú", 50, "Feminino"),
    new Aluno("Leo", 19, "Masculino"),
    new Aluno("Teto", 21, "Masculino")
};

foreach (var item in listaAluno)
{
    Console.WriteLine($"Nome: {item.Nome}\nIdade: {item.Idade}\nSexo: {item.Sexo}"); //=> iterando os objetos 
    Console.WriteLine();
}

class Aluno
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Sexo { get; set; }

    public Aluno(string? nome, int idade, string? sexo)
    {
        Nome = nome;    
        Idade = idade;
        Sexo = sexo;
    }
}