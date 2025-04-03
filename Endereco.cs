using System;
using static System.Console;
using static System.Convert;

class Endereco
{
    //atributos privados 
    private string? locadouro, cep, bairro, cidade, estado, numero, complemento;
    //acesso controlado get pra mostra e set pra receber 
    public string GetLocadouro()
    {
        return this.locadouro;
    }
    public void SetLogadouro(string logadouro)
    {
        this.locadouro = logadouro;
    }
    public string GetBairro()
    {
        return this.bairro;
    }
    public void SetBairro(string bairro)
    {
        this.bairro = bairro;
    }
    public string GetCep()
    {
        return this.cep;
    }
    public void SetCep(string cep)
    {
        this.cep = cep;
    }
    public string Getcidade()
    {
        return this.cidade;
    }
    public void SetCidade(string cidade)
    {
        this.cidade = cidade;
    }
    public string GetNumero()
    {
        return this.numero;
    }
    public void SetNumero(string numero)
    {
        this.numero = numero;
    }
    public string GetEstado()
    {
        return this.estado;
    }
    public void SetEstado(string estado)
    {
        this.estado = estado;
    }
    public string GetComplemento()
    {
        return this.complemento;
    }
    public void SetComplemento(string complemento)
    {
        this.complemento = complemento;
    }


}