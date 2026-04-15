namespace ClassesHeranca;

public class Professor : Funcionario
{
    public string AreaAtuacao { get; set; }
    public string Titulacao { get; set; }

    public Professor(
        string nome = "",
        string cpf = "",
        string rg = "",
        int idade = 0,
        Logradouro endereco = null,
        string numero = "",
        string complemento = "",
        string matricula = "",
        string areaAtuacao = "",
        string titulacao = ""
    ) : base(nome, cpf, rg, idade, endereco, numero, complemento, matricula)
    {
        AreaAtuacao = areaAtuacao;
        Titulacao = titulacao;
    }
}