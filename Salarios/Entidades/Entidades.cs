public abstract class  Empleados{
    public int id {get; set;}
    public string? nombre {get; set;}
    public string? cedula {get; set;}
    public decimal deducciones {get; set;}
     public abstract decimal sueldo_valor();
}

public class Vinculados : Empleados
{
    public decimal Bono {get; set;}
    public decimal Salario_Basico {get; set;}
     public override decimal sueldo_valor()
    {
        decimal sueldo;

        sueldo = Bono + Salario_Basico - deducciones;
        
        return sueldo;
    }
}

public class Contratistas : Empleados
{
    public int Trabajo_Horas {get; set;}
    public decimal Valor_Horas {get; set;}
     public override decimal sueldo_valor()
    {
        decimal salario_total;
        decimal subSueldo = Trabajo_Horas * Valor_Horas;
        salario_total = subSueldo - deducciones;
        return salario_total;
    }
}

public class General
{
    public static void IMPRIMIR(String mensaje)
{
    Console.WriteLine(mensaje);
}

public static string? lea (String mensaje)
{
    string? Escribir ="";
    IMPRIMIR(mensaje);
    try
    {
       Escribir = Console.ReadLine();
    }
    catch (IOException ex)
    {
        Console.WriteLine($"Error de E/S: {ex.Message}");
    }
    return Escribir;
}

public static Empleados Nuevo_Empleado(int op)
    {
        int id_Retorno;
        int TRABAJOHORAS;
        decimal VALORHORAS;
        decimal bonificacion;
        decimal salario_bas;
        while (!int.TryParse(lea("Ingrese el ID del empleado"), out id_Retorno))
        IMPRIMIR("ID inválido, intente nuevamente.");

        string? nombre = lea("Ingrese el nombre del empleado");
        string? cedula = lea("Ingrese la cedula del empleado");

        if(op == 1)
        {
           while (!int.TryParse(lea("Ingrese las horas trabajadas por el empleado"), out TRABAJOHORAS))
            IMPRIMIR("valor inválido, intente nuevamente."); 

            while (!decimal.TryParse(lea("Ingrese el valor de las horas"), out VALORHORAS))
            IMPRIMIR("valor inválido, intente nuevamente.");
            return new Contratistas
            {
                id = id_Retorno,
                nombre = nombre,
                cedula = cedula,
                Trabajo_Horas = TRABAJOHORAS,
                Valor_Horas = VALORHORAS,
            };
            
        }else if (op == 2)
        {
           while (!decimal.TryParse(lea("Ingrese bonificaciones del empleado"), out bonificacion))
           IMPRIMIR("valor inválido, intente nuevamente.");  
           while (!decimal.TryParse(lea("Ingrese el salario basico del empleado"), out salario_bas))
            IMPRIMIR("valor inválido, intente nuevamente."); 
            return new Vinculados
            {
                id = id_Retorno,
                nombre = nombre,
                cedula = cedula,
                Bono = bonificacion,
                Salario_Basico = salario_bas 
            };
        }else
        {
            IMPRIMIR("ERROR, OPCION NO VALIDA");
            return null;
        }
    }

    public static void Mostrar_Datos (Empleados obje)
    {
        IMPRIMIR($"ID del empleado: {obje.id}\nNombre del empleado: {obje.nombre}\nCedula del empleado: {obje.cedula}\nSalario del empleado: {obje.sueldo_valor()}\n");
    }

}