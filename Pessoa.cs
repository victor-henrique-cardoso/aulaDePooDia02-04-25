using System;
using static System.Console;
using static System.Convert;

class Pessoa
{
    //atributos privados 
    private string? nome, cpf, datanacimento;

    public Endereco? Endereco;

    //acesso controlado get pra mostra e set pra receber 
    public string Getdatanacimento()
    {
        return this.datanacimento;
    }
    public void SetDatanacimento(string datanacimento)
    {
        this.datanacimento = datanacimento;
    }
    public string GetNome()
    {
        return this.nome;
    }
    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    public string GetCpf()
    {
        return this.cpf;
    }
    public void SetCpf(string cpf)
    {
        this.cpf = cpf;
    }
    public Endereco GetEndereco()
    {
        return this.Endereco;
    }
    public void Setendereco(Endereco endereco)
    {
        this.Endereco = endereco;
    }
    public void ExibirinFormacaoPessoa()
    {
        WriteLine($"Nome: {GetNome()}\nCPF: {GetCpf()}\nData de Nacimento: {Getdatanacimento()}");

    }
}