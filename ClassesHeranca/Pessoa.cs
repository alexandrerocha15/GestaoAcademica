namespace ClassesHeranca;

public class Pessoa
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public int Idade { get; set; }
    public Logradouro Endereco { get; set; }
    public string Numero { get; set; }
    public string Complemento { get; set; }

    public Pessoa(
        string nome = "",
        string cpf = "",
        string rg = "",
        int idade = 0,
        Logradouro endereco = null,
        string numero = "",
        string complemento= ""
        )
    {
        Nome = nome;
        Cpf = cpf;
        Rg = rg;
        Idade = idade;
        Endereco = endereco;
        Numero = numero;
        Complemento = complemento;
    }
}