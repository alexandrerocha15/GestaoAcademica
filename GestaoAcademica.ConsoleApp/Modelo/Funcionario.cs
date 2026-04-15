namespace GestaoAcademica.ConsoleApp.Modelo;

public abstract class Funcionario : Pessoa
{
    public string Matricula { get; set; } = string.Empty;
    public decimal Salario { get; set; }



    public override void MostrarDados()
    {
        Console.WriteLine($"Funcionario: {Nome}");
        Console.WriteLine($"Matrícula:   {Matricula}");
        Console.WriteLine($"Salário:     {Salario}");
    }
}