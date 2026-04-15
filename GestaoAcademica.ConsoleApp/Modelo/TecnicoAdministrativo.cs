namespace GestaoAcademica.ConsoleApp.Modelo;

public class TecnicoAdministrativo : Funcionario
{
    public string Funcao {get;set;} = string.Empty;

    public override void MostrarDados()
    {
        base.MostrarDados();
        Console.WriteLine($"Função: {Funcao}");
    }
    public override string ToString()
    {
        return $"{base.ToString()} - Função: {Funcao}";
    }
}