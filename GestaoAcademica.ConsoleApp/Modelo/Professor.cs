namespace GestaoAcademica.ConsoleApp.Modelo;

public class Professor : Funcionario
{
    public string AreaAtuacao { get; set; } = string.Empty;
    public string Titulacao { get; set; } = string.Empty;

    public override void MostrarDados()
    {
        base.MostrarDados();
        Console.WriteLine($"Área: {AreaAtuacao}");
        Console.WriteLine($"Titulação: {Titulacao}");
    }
}