namespace ClassesHeranca;

public class TecnicoAdministrativo : Funcionario
{
    public string Funcao { get; set; }

    public TecnicoAdministrativo(
        string nome = "",
        string cpf = "",
        string rg = "",
        int idade = 0,
        Logradouro endereco = null,
        string numero = "",
        string complemento = "",
        string matricula = "",
        string funcao = ""
    ) : base(nome, cpf, rg, idade, endereco, numero, complemento, matricula)
    {
        Funcao = funcao;
    }
}