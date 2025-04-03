using System;
using static System.Console;
using static System.Convert;

class Pessoa
{
    public string nome = "";
    public string cpf = "";
    public string datanacimento = "";

    public Endereco Endereco;
    public Pessoa(){
        Endereco = new Endereco();
    }
    public void ExibirinFormacaoPessoa()
    {
        WriteLine($"Nome: {nome}\nCPF: {cpf}\nData de Nacimento: {datanacimento}");
        Endereco.MostraEndereco();
    }
}