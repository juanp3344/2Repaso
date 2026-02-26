
<<<<<<< HEAD

using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Runtime.CompilerServices;

=======
>>>>>>> d876ac6a40d078aa8827c50f88a8f2f141496e34
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

<<<<<<< HEAD
            universidad.sedes = new List<sedes>();
            universidad.sedes.Add(new sedes(){ID=1, Nombre = "Robledo"});
            universidad.sedes.Add(new sedes(){ID=2, Nombre = "fraternidad"});
=======
            Universidades universidad2 = new Universidades()
            {
               ID = 2,
               Nombre = "UDEA"  
            };

            universidad.sedes = new List<sedes>();
            universidad.sedes.Add(new sedes(){ID=1, Nombre = "Robledo", _Universidad=universidad});
            universidad.sedes.Add(new sedes(){ID=2, Nombre = "fraternidad", _Universidad= universidad});
            
            universidad2.sedes = new List<sedes>();
            universidad2.sedes.Add(new sedes(){ID=3, Nombre = "Universidad", _Universidad=universidad2});

>>>>>>> d876ac6a40d078aa8827c50f88a8f2f141496e34
            int op = 0;
            do{
        op = int.Parse(General.lea("MENU DE UNIVERSIDAD"+
                            "\n1. Mostrar sedes"+
<<<<<<< HEAD
                            "\n2. Agregar sede"));
        switch (op)
        {
            case 1:
=======
                            "\n2. Agregar sede"+
                            "\n3. Eliminar una sede"));
        switch (op)
        {
            
            case 1:
                General.IMPRIMIR("\nITM");
>>>>>>> d876ac6a40d078aa8827c50f88a8f2f141496e34
                foreach (var sedes in universidad.sedes)
                {
                    General.IMPRIMIR("ID: "+ sedes.ID + "\nNombre: "+ sedes.Nombre);
                }
<<<<<<< HEAD
=======
                General.IMPRIMIR("\nUDEA");
                foreach (var sedes in universidad2.sedes)
                {
                    General.IMPRIMIR("ID: "+ sedes.ID + "\nNombre: "+ sedes.Nombre);
                }
>>>>>>> d876ac6a40d078aa8827c50f88a8f2f141496e34
            break;
            case 2:
                int id = int.Parse(General.lea("Ingrese el ID de la sede"));
                string Nombre = General.lea("Ingrese el nombre de la sede");
                universidad.sedes.Add(new sedes(){ID=id, Nombre = Nombre});
            break;
<<<<<<< HEAD
        }
            }while (op!=0);
            
                
            
=======
            case 3:
            int buscar = int.Parse(General.lea("Ingrese el id del que quiera eliminar"));
           for (int i = 0; i < universidad.sedes.Count; i++)
        {
            if (universidad.sedes[i].ID == buscar)
            {
                universidad.sedes.RemoveAt(i);
                break;
            }
        }
            break;
        }

            }while (op!=0);
>>>>>>> d876ac6a40d078aa8827c50f88a8f2f141496e34
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
