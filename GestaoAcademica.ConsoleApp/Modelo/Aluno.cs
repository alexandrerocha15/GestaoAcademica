namespace GestaoAcademica.ConsoleApp.Modelo;

public class Aluno : Pessoa
{
    public string Matricula { get; set; } = string.Empty;

    public override void MostrarDados()
    {
        Console.WriteLine($"Aluno: {Nome}");
        Console.WriteLine($"Matrícula: {Matricula}");
    }
    public override string ToString()
    {
        return $"Aluno: {Nome} - Matrícula: {Matricula}";
    }
}