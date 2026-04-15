using System;

namespace ClassesHeranca;

public class Funcionario : Pessoa
{
    public string Matricula { get; set; }

    public Funcionario(
        string nome = "",
        string cpf = "",
        string rg = "",
        int idade = 0,
        Logradouro endereco = null,
        string numero = "",
        string complemento = "",
        string matricula = ""
    ) : base(nome, cpf, rg, idade, endereco, numero, complemento)
    {
        Matricula = matricula;
    }
}
