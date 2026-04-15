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

        Professor professor = new Professor();
        professor.Nome = "Carlos";
        professor.Matricula = "P01";
        professor.Salario = 3500;
        professor.AreaAtuacao = "Tecnologia";
        professor.Titulacao = "Mestre";

        Coordenador coordenador = new Coordenador();
        coordenador.Nome = "Gattino";
        coordenador.Matricula = "CO01";
        coordenador.Salario = 7800;
        coordenador.SenhaDoAlarme = "025";

        TecnicoAdministrativo tecnico = new TecnicoAdministrativo();
        tecnico.Nome = "Leti";
        tecnico.Matricula = "TEC02";
        tecnico.Funcao = "Desempenho";

        pessoas.Add(aluno);
        pessoas.Add(professor);
        pessoas.Add(coordenador);
        pessoas.Add(tecnico);

        foreach (var p in pessoas)
        {
            p.MostrarDados();
            Console.WriteLine();
        }
    }
}