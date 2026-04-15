using ClassesHeranca;

namespace AplicacaoHeranca;

public class GeradorDados
{
    public List<Pessoa> ObterPessoas()
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        Curso cursoSI = new Curso(
            "Sistemas de Informação",
            "SI2026",
            3000,
            "Curso de graduação voltado à tecnologia, sistemas e gestão da informação"
        );

        Logradouro endereco1 = new Logradouro(
            "Avenida Dom Pedro II",
            "Avenida",
            "Centro",
            "Lages",
            "SC",
            "88501-001"
        );

        Logradouro endereco2 = new Logradouro(
            "Rua Marechal Deodoro",
            "Rua",
            "Coral",
            "Lages",
            "SC",
            "88509-120"
        );

        Pessoa pessoa = new Pessoa(
            "Alexandre Rocha",
            "12345678901",
            "6543210",
            29,
            endereco1,
            "145",
            "Casa"
        );

        Funcionario funcionario = new Funcionario(
            "Mariana de Souza",
            "23456789012",
            "7654321",
            31,
            endereco1,
            "220",
            "Sala Administrativa",
            "FUNC100"
        );

        Aluno aluno1 = new Aluno(
            "Carlos Henrique Almeida",
            "34567890123",
            "8765432",
            20,
            endereco2,
            "58",
            "Apto 02",
            "AL2026001",
            cursoSI
        );

        Aluno aluno2 = new Aluno(
            "Fernanda Oliveira Ramos",
            "45678901234",
            "9876543",
            21,
            endereco1,
            "312",
            "Casa",
            "AL2026002",
            cursoSI
        );

        Aluno aluno3 = new Aluno(
            "Lucas Gabriel Mendes",
            "56789012345",
            "1098765",
            22,
            endereco2,
            "91",
            "Fundos",
            "AL2026003",
            cursoSI
        );

        Professor professor1 = new Professor(
            "Ricardo Martins",
            "67890123456",
            "2109876",
            42,
            endereco1,
            "18",
            "Sala 05",
            "PR2026001",
            "Tecnologia",
            "Mestre"
        );

        Professor professor2 = new Professor(
            "Helena Duarte",
            "78901234567",
            "3210987",
            47,
            endereco2,
            "77",
            "Sala 08",
            "PR2026002",
            "Gestão",
            "Doutora"
        );

        Coordenador coordenador = new Coordenador(
            "Patricia Cardoso",
            "89012345678",
            "4321098",
            50,
            endereco1,
            "10",
            "Coordenação",
            "CO2026001",
            "AbcBolinhas"
        );

        TecnicoAdministrativo tecnico1 = new TecnicoAdministrativo(
            "Diego Pereira",
            "90123456789",
            "5432109",
            28,
            endereco2,
            "44",
            "Setor de TI",
            "TA2026001",
            "Desenvolvedor"
        );

        TecnicoAdministrativo tecnico2 = new TecnicoAdministrativo(
            "Juliana Ferreira",
            "01234567890",
            "6543219",
            35,
            endereco1,
            "26",
            "Secretaria",
            "TA2026002",
            "Suporte Acadêmico"
        );

        pessoas.Add(pessoa);
        pessoas.Add(funcionario);
        pessoas.Add(aluno1);
        pessoas.Add(aluno2);
        pessoas.Add(aluno3);
        pessoas.Add(professor1);
        pessoas.Add(professor2);
        pessoas.Add(coordenador);
        pessoas.Add(tecnico1);
        pessoas.Add(tecnico2);

        return pessoas;
    }
}