using System;
using static System.Console;
using static System.Convert;

class Escola
{
    public string? nomeescola;
    public string? cnpj;
    public string? tipo;

    public Endereco? Endereco;

    public void MostrasInformacaoEscola()
    {
        WriteLine($"Nome da escola: {nomeescola}\nCNPJ: {cnpj}\nO tipo da escola: {tipo}\nEndereço: {Endereco}");
        Endereco.MostraEndereco();
    }
}