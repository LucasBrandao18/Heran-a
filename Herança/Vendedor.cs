using System;

class Vendedor:Empregado{   
    private double valorVendas, comissao;

    public double Sell{
        get{return valorVendas;}
        set{valorVendas = value;}
    }
    public double CommV{
        get{return comissao;}
        set{comissao = valorVendas*35/100;}
    }

    public void inicializarVendedor(double valorVendas, double comm){
        Sell = valorVendas;
        CommV = comm;
    }
    public override void calcularSalario(){
        double salarioVendedor = Pay + CommV;//tive q dar valor ao "Pay" dnv, n gosto disso
        Console.WriteLine("Salario Vendedor: {0}", salarioVendedor);
    }    
}