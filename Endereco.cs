using System;
using static System.Console;
using static System.Convert;

class Endereco
{
    public string? locadouro;
    public string? cep;
    public string? bairro;

    public  void MostraEndereco(){
        WriteLine($"Locadoro: {locadouro}\nCep: {cep}\nBairro: {bairro}");
    }

}