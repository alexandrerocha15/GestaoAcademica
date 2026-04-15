namespace ClassesHeranca;
/* 
    - Toda classe obrigatoriamente deve herdar de alguém
    - Seja de uma classe base ou da classe object, que é a classe raiz de todas 
    as classes em C#
    - Quando não especificamos uma classe base, a classe herda implicitamente da 
    classe object  
*/
public class Curso : Object
{
    public string Nome { get; set; }
    public string Codigo { get; set; }
    public int CargaHoraria { get; set; }
    public string Descricao { get; set; }
    // construtor com parâmetros opcionais para facilitar a criação de objetos Curso
    public Curso(
        string nome = "",
        string codigo = "",
        int cargaHoraria = 0,
        string descricao = "")
    {
        Nome = nome;
        Codigo = codigo;
        CargaHoraria = cargaHoraria;
        Descricao = descricao;
    }
}

