using GestaoAcademica.ConsoleApp.Modelo;

namespace GestaoAcademica.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        Aluno aluno = new Aluno();
        aluno.Nome = "Alexandre";
        aluno.Matricula = "123";

        Funcionario funcionario = new Funcionario();
        funcionario.Matricula = "2b";
        pessoas.Add(aluno);

        foreach (var p in pessoas)
        {
            p.MostrarDados();
        }
    }
}