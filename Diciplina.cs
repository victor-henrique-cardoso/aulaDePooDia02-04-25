using System;
using static System.Console;
using static System.Convert;

class Diciplina
{
    private string nomedaDiciplina, codigoDaDiciplina, descricaoEmenta, areaConhecimento;

    private int cargaHoraria, anoSerieRecomentadada;

    public string GetNomeDiciplina()
    {
        return this.nomedaDiciplina;
    }
    public void SetNomeDiciplina(string nomedaDiciplina)
    {
        this.nomedaDiciplina = nomedaDiciplina;
    }
    public string GetCodigoDiciplina()
    {
        return this.codigoDaDiciplina;
    }
    public void SetCodigoDiciplina(string codigoDaDiciplina)
    {
        this.codigoDaDiciplina = codigoDaDiciplina;
    }
    public string GetDescricaoEmenta()
    {
        return this.descricaoEmenta;
    }
    public void SetDescricaoEmenta(string descricaoEmenta)
    {
        this.descricaoEmenta = descricaoEmenta;
    }
    public string GetareAConhecimento()
    {
        return this.areaConhecimento;
    }
    public void SetareAConhecimento(string areaConhecimento)
    {
        this.areaConhecimento = areaConhecimento;
    }
    public int GetcargaHoraria()
    {
        return this.cargaHoraria;
    }
    public void SetcargaHoraria(int cargaHoraria){
        this.cargaHoraria = cargaHoraria;
    }
    public int GetanoSerieRecomentadada(){
        return this.anoSerieRecomentadada;
    }
    public void SetanoSerieRecomentadada(int anoSerieRecomentadada){
        this.anoSerieRecomentadada = anoSerieRecomentadada;
    }



}