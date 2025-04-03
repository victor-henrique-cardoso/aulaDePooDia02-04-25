using System;
using static System.Console;
using static System.Convert;

class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa();
        Escola escola = new Escola();
        Endereco endereco = new Endereco();
        Write("informe o seu nome: ");
        pessoa.nome = ReadLine()!;
        Write("informe o seu CPF: ");
        pessoa.cpf = ReadLine()!;
        Write("informe a sua data de nacimento: ");
        pessoa.datanacimento = ReadLine()!;
         Write("informe o seu endereço: (cep) (locadoro) (bairro) ");
        endereco.cep=ReadLine();
        endereco.bairro=ReadLine();
        endereco.locadouro=ReadLine();

        pessoa.ExibirinFormacaoPessoa();

        Write("informe o nome da escola: ");
        escola.nomeescola = ReadLine();
        Write("informe o seu CNPJ: ");
        escola.cnpj = ReadLine();
        Write("informe p tipo dela: ");
        escola.tipo = ReadLine();
        Write("informe o endereço da escola: (cep) (locadoro) (bairro) ");
        endereco.cep=ReadLine();
        endereco.bairro=ReadLine();
        endereco.locadouro=ReadLine();

        escola.MostrasInformacaoEscola();

    }
}