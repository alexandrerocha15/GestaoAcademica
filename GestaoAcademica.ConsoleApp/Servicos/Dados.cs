using GestaoAcademica.ConsoleApp.Modelo;
namespace GestaoAcademica.ConsoleApp.Servicos;

public class PessoaService
{
    public List<Pessoa> GerarPessoasTeste()
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        // Aluno
        Aluno aluno = new Aluno();
        aluno.Nome = "Alexandre";
        aluno.Matricula = "123";

        // Professor
        Professor professor = new Professor();
        professor.Nome = "Luciano";
        professor.Matricula = "P01";
        professor.Salario = 3500;
        professor.AreaAtuacao = "Tecnologia";
        professor.Titulacao = "Mestre";

        // Coordenador
        Coordenador coordenador = new Coordenador();
        coordenador.Nome = "Gattino";
        coordenador.Matricula = "CO01";
        coordenador.Salario = 5000;
        coordenador.SenhaDoAlarme = "025";

        // Técnico Administrativo
        TecnicoAdministrativo tecnico = new TecnicoAdministrativo();
        tecnico.Nome = "João";
        tecnico.Matricula = "TA01";
        tecnico.Salario = 2500;
        tecnico.Funcao = "Desenvolvedor";

        // adicionando na lista
        pessoas.Add(aluno);
        pessoas.Add(professor);
        pessoas.Add(coordenador);
        pessoas.Add(tecnico);

        return pessoas;
    }
}