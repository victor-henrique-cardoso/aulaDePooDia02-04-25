using System;
using static System.Console;
using static System.Convert;

class Professor{
    private string? nomeCompleto, matriculaFuncional, dataNacimento, diciplinaPrincipal, emailComperativo; 
    private decimal salario;

    public string GetNomeCompleto(){
        return this.nomeCompleto;
    }
    public void SetNomeCompleto(string nomeCompleto){
        this.nomeCompleto = nomeCompleto;
    }
    public string GetmatriculaFuncional(){
        return this.matriculaFuncional;
    }
    public void SetmatriculaFuncional(string matriculaFuncional){
        this.matriculaFuncional = matriculaFuncional;
    }
    public string Getdatanacimento(){
        return this.dataNacimento;
    }
    public void SetDatanacimento(string dataNacimento){
        this.dataNacimento = dataNacimento;
    }
    public string GetDiciplinaPrincipal(){
        return this.diciplinaPrincipal;
    }
    public void SetDicplinaPrincipal(){
        this.diciplinaPrincipal = diciplinaPrincipal;
    }
    public string GetEmailcomperativo(){
        return this.emailComperativo;
    }
    public void SetEmailcomperativo(string emailComperativo){
        this.emailComperativo = emailComperativo;
    }

    public decimal GetSalario(){
        return this.salario;
    }
    public void SetSalario(string salario){
        this.salario = salario;
    }

}