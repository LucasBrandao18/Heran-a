using System;

class Operario:Empregado{
    private double valorProducao, comissao;

    public double Prod{
        get{return valorProducao;}
        set{valorProducao = value;}
    }
    public double Comm{
        get{return comissao;}
        set{comissao = valorProducao*25/100;}
    }

    public void inicializarOperario(double valorProducao, double comissao){
        Prod = valorProducao;
        Comm = comissao;
    }
    public override void calcularSalario(){
        double salarioOperario = Pay + Comm;
        Console.WriteLine("Salario Operario: {0}", salarioOperario);
    }    
}