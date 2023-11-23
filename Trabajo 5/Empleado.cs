using System;

public class Empleado : INterfaceInfo
{
    private string nombre;
    private double salario;
    public Empleado(string nombre, double salario)
    {
        this.nombre = nombre;
        this.salario = salario;
    }
    public Empleado()
    {
        this.nombre = "defaul";
        this.salario = 490;
    }
    public double salarioAnula()
    {
        return this.salario * 12;
    }

    public string getNombre()
    {
        return this.nombre;
    }

    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public double getSalario()
    {
        return this.salario;
    }
    public void setSalario(double salario)
    {
        this.salario = salario;
    }
    public string IMostrarInformacion()
    { 
       return "Soy Empleado";
    }

}
