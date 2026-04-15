namespace ClassesHeranca;

public class Aluno : Pessoa
{
    public string Matricula { get; set; }
    public Curso CursoAluno { get; set; }

    public Aluno(
        string nome = "",
        string cpf = "",
        string rg = "",
        int idade = 0,
        Logradouro endereco = null,
        string numero = "",
        string complemento = "",
        string matricula = "",
        Curso cursoAluno = null
    ) : base(nome, cpf, rg, idade, endereco, numero, complemento)
        {
            Matricula = matricula;
            CursoAluno = cursoAluno;
        }
}