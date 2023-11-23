using System;
//Extencion de la interface
public class Empleado : INterfaceInfo
{
    //declaracion de atributos
    private string nombre;
    private double salario;
    //creacion del constructor con valores
    public Empleado(string nombre, double salario)
    {
        this.nombre = nombre;
        this.salario = salario;
    }
    //creacion de constructor con valores inciales
    public Empleado()
    {
        this.nombre = "defaul";
        this.salario = 490;
    }
    //creacion de funcion Salario Anual 
    public double salarioAnula()
    {
        return this.salario * 12;
    }
    //Creacion de getters and setters
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
    //implementacion de la interface
    public string IMostrarInformacion()
    { 
       return "Soy Empleado";
    }

}
