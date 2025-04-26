using System;
using static System.Console;
using static System.Convert;

class Turma{
    private string? codigoTurma, semestrePerioto, sala,  turno;
    private int anoletivo, maximoAluno;

    public string GetCodigoTurma(){
        return this.codigoTurma;
    }
    public void SetCodigoTurma(string codigoTurma){
        this.codigoTurma=codigoTurma;
    }
    public string GetsemestrePerioto(){
        return this.semestrePerioto;

    }
    public void SetSemestrePerioto(string semestrePerioto){
        this.semestrePerioto=semestrePerioto;
    }
    public string GetSala(){
        return this.sala;
    }
    public void Setsala(string sala){
        this.sala = sala;
    }
     public string GetTurno(){
        return this.turno;
    }
    public void SetTurno(string turno){
        this.turno = turno;
    }
     public int Getanoletivo(){
        return this.anoletivo;
    }
    public void Setanoletivo(int anoletivo){
        this.anoletivo = anoletivo;
    }
     public int GetmaximoAluno(){
        return this.maximoAluno;
    }
    public void Setsala(int maximoAluno){
        this.maximoAluno = maximoAluno;
    }

}