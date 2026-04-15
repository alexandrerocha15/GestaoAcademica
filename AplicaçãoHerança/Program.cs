using AplicacaoHeranca;
using ClassesHeranca;
// Alexandre Rocha

internal class Program
{
    public Program()
    {
        GeradorDados gerador = new GeradorDados();
        ExibirDados exibidor = new ExibirDados();

        List<Pessoa> pessoas = gerador.ObterPessoas();

        foreach (var item in pessoas)
        {
            exibidor.ExibirPessoa(item);
        }
    }

    private static void Main(string[] args) => _ = new Program();

}