using System.Reflection;
using GestaoAcademica.ConsoleApp.Modelo;
using GestaoAcademica.ConsoleApp.Servicos;

namespace GestaoAcademica.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        PessoaService service = new PessoaService();

        List<Pessoa> pessoas = service.GerarPessoasTeste();


        foreach (var p in pessoas)
        {
            p.MostrarDados();
            Console.WriteLine();
        }
    }
}