namespace ClassesHeranca;

public class Coordenador : Funcionario
{
    public string Senha { get; set; }

    public Coordenador(
        string nome = "",
        string cpf = "",
        string rg = "",
        int idade = 0,
        Logradouro endereco = null,
        string numero = "",
        string complemento = "",
        string matricula = "",
        string senha = ""
    ) : base(nome, cpf, rg, idade, endereco, numero, complemento, matricula)
    {
        Senha = senha;
    }
}