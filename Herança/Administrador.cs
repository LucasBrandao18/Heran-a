using System;

class Administrador:Empregado{

    private double ajudaDeCusto;

    public double Cost{
        get	{return ajudaDeCusto;}
        set {ajudaDeCusto = value;}
    }
    //metodos
    public void inicializarAdmin(double ajudaDeCusto){
        Cost = ajudaDeCusto;
    }
    public override void calcularSalario(){
        double salarioAdmin = Pay + Cost;
        Console.WriteLine("Salario Admin: {0}", salarioAdmin);
    }
}