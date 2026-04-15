using ClassesHeranca;

namespace AplicacaoHeranca;

public class ExibirDados
{
    public void ExibirPessoa(Pessoa item)
    {
        DefinirCor(item);

        Console.WriteLine($"=== {item.GetType().Name.ToUpper()} ===");
        Console.WriteLine($"Nome: {item.Nome}");
        Console.WriteLine($"CPF: {item.Cpf}");
        Console.WriteLine($"RG: {item.Rg}");
        Console.WriteLine($"Idade: {item.Idade}");
        Console.WriteLine($"Endereço: {item.Endereco.Nome}");
        Console.WriteLine($"Número: {item.Numero}");
        Console.WriteLine($"Complemento: {item.Complemento}");

        if (item is Funcionario funcionario)
        {
            Console.WriteLine($"Matrícula: {funcionario.Matricula}");
        }

        if (item is Aluno aluno)
        {
            Console.WriteLine($"Curso: {aluno.CursoAluno.Nome}");
        }

        if (item is Professor professor)
        {
            Console.WriteLine($"Área de Atuação: {professor.AreaAtuacao}");
            Console.WriteLine($"Titulação: {professor.Titulacao}");
        }

        if (item is Coordenador coordenador)
        {
            Console.WriteLine($"Senha: {coordenador.Senha}");
        }

        if (item is TecnicoAdministrativo tecnico)
        {
            Console.WriteLine($"Função: {tecnico.Funcao}");
        }

        Console.ResetColor();
        Console.WriteLine("----------------------------------");
    }

    private void DefinirCor(Pessoa item)
    {
        if (item is Coordenador)
            Console.ForegroundColor = ConsoleColor.Magenta;

        else if (item is Professor)
            Console.ForegroundColor = ConsoleColor.Yellow;

        else if (item is Aluno)
            Console.ForegroundColor = ConsoleColor.Green;

        else if (item is TecnicoAdministrativo)
            Console.ForegroundColor = ConsoleColor.Blue;

        else if (item is Funcionario)
            Console.ForegroundColor = ConsoleColor.Cyan;

        else
            Console.ForegroundColor = ConsoleColor.White;
    }
}