using System;

public class Gerente:Empleado,INterfaceInfo 
{
    private string departamento;

    public Gerente(string nombre, double salario , string departamento) : base(nombre, salario)
    {
        this.departamento= departamento;
    }
    public string getDepartamento()
    {
        return this.departamento;
    }
    public new string IMostrarInformacion()
    {
        return "Soy Gerente";
    }
}
