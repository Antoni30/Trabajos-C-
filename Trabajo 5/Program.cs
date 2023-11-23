using System;
using System.Timers;

class Program
{
    static void Main()
    {
        #pragma warning disable CS8600
        #pragma warning disable CS8604
        int opc;
        //Creamos las listas tanto de Empleados como Gerentes para guardar todos mis datos
        List<Empleado> empleadoList = new List<Empleado>();
        List<Gerente> gerenteList = new List<Gerente>();
        //Creacion de un bucle con el cual hacemos que sea interactivo con las opciones
        do
        {
            Console.Clear();
            //Declaramos las variables que usaremos durante todo nuestro programa
            string nombre;
            string departamento;
            double salario;
            Console.WriteLine("Seleccione una Opcion");
            Console.WriteLine("1.-Agregar Empleado");
            Console.WriteLine("2.-Agregar Gerente");
            Console.WriteLine("3.-Mostrar Datos");
            Console.WriteLine("0.-Exit");
            //Opcion en -1 como opcion de default para que el programa no se cierre
            opc = -1;
            //Validamos los errores de ingresos de datos
            try
            {
                //Dectura de la opcion selecionada por el USURIO
                Console.Write("----> ");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        //Campuramos algun error que pueda ocurrir
                        try
                        {
                            //Creamos nuestro empreado con los datos definidos en nuestra clase
                            Console.Clear();
                            //Declaramos el objeto newEmpleado
                            Empleado newEmpleado;
                            //Pedimos por consola el ingreso de datos
                            Console.WriteLine("Crear Empleado");
                            Console.WriteLine("Igrese Nombre");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Igrese Salario");
                            salario = Convert.ToDouble(Console.ReadLine());
                            //comprobamos que el salario no sea negativo
                            if (salario > 0)
                            {
                                //Creacion del Objeto  empleado con los parametros
                                newEmpleado = new Empleado(nombre, salario);
                                //Agregamos a nuestra lista, nuestro nuevo empleado
                                empleadoList.Add(newEmpleado);
                                Console.WriteLine("ok");
                                Console.ReadLine();
                            }
                            else
                            {
                                //Muestra mensaje de error
                                Console.WriteLine("El salario es menor a 0");
                                Console.ReadLine();
                            }
                        }
                        catch
                        {
                            Console.WriteLine("ERROR!!!\nRecuerde ingresar valores numericos en el salario");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        //capturamos cualquier error
                        try
                        {
                            Console.Clear();
                            //Declaramos el objeto newGerente
                            Gerente newGerente;
                            Console.WriteLine("Crear Empleado");
                            //Pedimos los datos por consola
                            Console.WriteLine("Igrese Nombre");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Igrese Salario");
                            salario = Convert.ToDouble(Console.ReadLine());
                            //Comprobamos que es salario no sea negarivo
                            if (salario > 0){
                                Console.WriteLine("Igrese Departamento");
                                departamento = Console.ReadLine();
                                //creamos nuestro objeto con los parametros
                                newGerente = new Gerente(nombre, salario, departamento);
                                //agregamos a nuestra lista  gerente
                                gerenteList.Add(newGerente);
                                Console.WriteLine("ok");
                                Console.ReadLine();
                            }
                            else
                            {
                                //Muestra mensaje de error
                                Console.WriteLine("El salario es menor a 0");
                                Console.ReadLine();
                            }
                        }
                        catch
                        {
                            Console.WriteLine("ERROR!!!\nRecuerde ingresar valores numericos en el salario");
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        // mostramos la informacion que tenemos registrada en nuestras listas
                        Console.WriteLine("Datos Empresa");
                        // recorremos con un foreach donde empleado es un elemento de la lista empleados
                        if (empleadoList.Count!=0 || gerenteList.Count!=0)
                        {
                            foreach (Empleado empleado in empleadoList)
                            {
                                Console.WriteLine($"Nombre: {empleado.getNombre()}, Salario: {empleado.getSalario()}, InfoExta: {empleado.IMostrarInformacion()},Salario Anual {empleado.salarioAnula()}");
                            }
                            foreach (Gerente gerente in gerenteList)
                            {
                                Console.WriteLine($"Nombre: {gerente.getNombre()}, Salario: {gerente.getSalario()}, Departamento: {gerente.getDepartamento()}, InfoExta: {gerente.IMostrarInformacion()},Salario Anual {gerente.salarioAnula()}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("BD Sin Datos Registrados");
                        }
                        Console.WriteLine("ok");
                        Console.ReadLine();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("y Como dijo mi ex, hasta aqui nomas :') \nVuelva pronto ^^/");
                        Console.ReadLine();
                        break;
                }
            }
            catch
            {
                Console.Clear();
               Console.WriteLine("error, no es niguna de las opciones mencianadas\nVuelva Intentar");
                Console.ReadLine();
            }
        } while (opc!=0);
    }
}