using System;
using static System.Console;
using static System.Convert;

class Diciplina{
    private string nomedaDiciplina, codigoDaDiciplina, descricaoEmenta, areaConhecimento;
    
    private int cargaHoraria, anoSerieRecomentadada;

    public string GetNomeDiciplina(){
        return this.nomedaDiciplina;
    }
    public void SetNomeDiciplina(string nomedaDiciplina)
    {
        this.nomedaDiciplina = nomedaDiciplina;
    }
    public string GetCodigoDiciplina(){
        return this.codigoDaDiciplina;
    }
    public void SetCodigoDiciplina(string codigoDaDiciplina){
        this.codigoDaDiciplina = codigoDaDiciplina;
    }
    public string GetDescricaoEmenta (){
        return this.descricaoEmenta;
    }
    


}