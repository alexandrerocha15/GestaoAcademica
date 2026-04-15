namespace GestaoAcademica.ConsoleApp.Modelo;

public class Coordenador : Funcionario
{
    public string SenhaDoAlarme {get; set;} = string.Empty;


    public override void MostrarDados()
    {
        base.MostrarDados();
        Console.WriteLine($"Senha do Alarme: {SenhaDoAlarme}");
    }
    public override string ToString()
    {
        return $"{base.ToString()} - Senha do Alarme: {SenhaDoAlarme}";
    }
}