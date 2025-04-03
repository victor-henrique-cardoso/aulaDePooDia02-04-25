using System;
using static System.Console;
using static System.Convert;

class Escola
{
    private string? nomeescola,cnpj,tipo;

    public Endereco Endereco;

     public string GetNomeescola()
    {
        return this.nomeescola!;
    }
    public void Settipo(string tipo)
    {
        this.tipo = tipo;
    }
  
    public void SetNomeEscola(string nomeescola)
    {
        this.nomeescola = nomeescola;
    }
    public string GetCnpj()
    {
        return this.cnpj!;
    }
    public void Setcnpj(string cnpj)
    {
        this.cnpj = cnpj;
    }
    public Endereco GetEndereco()
    {
        return this.Endereco;
    }
    public void Setendereco(Endereco endereco)
    {
        this.Endereco = endereco;
    }

    public void MostrasInformacaoEscola()
    {
        WriteLine($"Nome da escola: {GetNomeescola()}\nCNPJ: {GetCnpj()}\nO tipo da escola: {tipo}\nEndereço: {GetEndereco()}");
    }
}