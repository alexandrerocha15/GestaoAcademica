namespace GestaoAcademica.ConsoleApp.Modelo;

public abstract class Pessoa
{
    public string Nome { get; set; } = string.Empty;

    public abstract void MostrarDados();

}