using System.CodeDom.Compiler;

class Program
{
    static void Main(string[] args)
    {
        int op = 0;
        List<Empleados> listaEmpleados = new List<Empleados>();
        do{
        op = int.Parse(General.lea($"MENU DE EMPLEADOS \n1.Ingresar empleado \n2.Mostrar lista de empleados \n0.Salir del programa "));
        switch (op)
        {
            case 1:
            int opcion;
            while (!int.TryParse(General.lea("QUE TIPO DE EMPLEADO QUIERE INGRESAR \n1.Contratista \n2.Vinculado"), out opcion))
            {
            General.IMPRIMIR("Opción inválida. Ingrese un número.");
            }   
            Empleados obje = General.Nuevo_Empleado(opcion);
            listaEmpleados.Add(obje);
            break;
            case 2:
            General.IMPRIMIR("CONTRATISTAS:\n");
            foreach (var emp in listaEmpleados)
                    {
                        if(emp is Contratistas contratista)
                        {
                            General.Mostrar_Datos(contratista);
                    }
                    }
            General.IMPRIMIR("VINCULADOS:\n");
            foreach (var empl in listaEmpleados)
                        {
                            if(empl is Vinculados vinculado)
                        {
                            General.Mostrar_Datos(vinculado);
                        }
                        }
            
            break;
        }
        }while(op!=0);
    }
}