using System;

//Herencia del empleado y el uso de polimorfismo con la interface
public class Gerente:Empleado,INterfaceInfo 
{
    //declaracion de atributos
    private string departamento;
    //Creacion de un constructor con datos de la herencias
    public Gerente(string nombre, double salario , string departamento) : base(nombre, salario)
    {
        this.departamento= departamento;
    }
    public string getDepartamento()
    {
        return this.departamento;
    }
    //sobrecarga de la funcion
    public new string IMostrarInformacion()
    {
        return "Soy Gerente";
    }
}
