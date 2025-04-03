using System;
using static System.Console;
using static System.Convert;

class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa(); // objeto pessoa 
        Escola escola = new Escola(); // objeto escola 
        Endereco endereco = new Endereco();
        Write("informe o seu nome: ");
        pessoa.SetNome(ReadLine()!);
        Write("informe o seu CPF: ");
        pessoa.SetCpf(ReadLine()!);
        Write("informe a sua data de nacimento: ");
        pessoa.SetDatanacimento(ReadLine()!);
       


        pessoa.ExibirinFormacaoPessoa();

        Write("informe o nome da escola: ");
        escola.SetNomeEscola(ReadLine()!);
        Write("informe o seu CNPJ: ");
        escola.Setcnpj(ReadLine()!);
        Write("informe p tipo dela: ");
        escola.Settipo(ReadLine()!);
    

        escola.MostrasInformacaoEscola();

    }
}