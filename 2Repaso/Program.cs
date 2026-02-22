

using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Runtime.CompilerServices;

public class Universidades{

public int ID {get; set;}
public string? Nombre {get; set;}
public DateTime Fecha {get; set;}
public bool Activo {get; set;}

public List<sedes> sedes{get; set;}

}

public class sedes{
public int ID {get; set;}
public string? Nombre {get; set;}
public decimal Capacidad {get; set;}
public int Universidad{get; set;}
public Universidades _Universidad {get; set;}

}

class Program
    {
        static void Main(string[] args)
        {
            Universidades universidad = new Universidades()
            {
                ID = 1,
                Nombre= "ITM"
            };

            universidad.sedes = new List<sedes>();
            universidad.sedes.Add(new sedes(){ID=1, Nombre = "Robledo"});
            universidad.sedes.Add(new sedes(){ID=2, Nombre = "fraternidad"});
            int op = 0;
            do{
        op = int.Parse(General.lea("MENU DE UNIVERSIDAD"+
                            "\n1. Mostrar sedes"+
                            "\n2. Agregar sede"));
        switch (op)
        {
            case 1:
                foreach (var sedes in universidad.sedes)
                {
                    General.IMPRIMIR("ID: "+ sedes.ID + "\nNombre: "+ sedes.Nombre);
                }
            break;
            case 2:
                int id = int.Parse(General.lea("Ingrese el ID de la sede"));
                string Nombre = General.lea("Ingrese el nombre de la sede");
                universidad.sedes.Add(new sedes(){ID=id, Nombre = Nombre});
            break;
        }
            }while (op!=0);
            
                
            
        }
        
    }

public class General{
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

}
