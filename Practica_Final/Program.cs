



public class Bibliotecas{
    public int id {get; set;}
    public string? Nombre {get; set;}
    public string? Ciudad {get; set;}
    public string? correo_electronico {get; set;}
    public string? Telefono {get; set;}
    public bool Activa {get; set;}

    public List<Prestamos> Prestamo{get; set;}
    public List<Libros> Libro{get; set;}
    public List<Usuarios> Usuario{get; set;}
}

public class Libros{
public int id {get; set;}
public string? Titulo {get; set;}
public string? Nombre {get; set;}
public string? ISBN {get; set;}
public bool Activo {get; set;}
public int Biblioteca {get; set;}
public int Autor {get; set;}
public int Multa {get; set;}

public Bibliotecas _Biblioteca {get; set;}
public Autores _Autor {get; set;}
public Multas _Multa {get; set;}
public List<Prestamos> Prestamo{get; set;}
}

public class Usuarios: Personas{
public DateTime Fecha_Registro{get; set;}
}

public class Personas{
public int id {get; set;}
public string?  Nombre {get; set;}
public string? Cedula {get; set;}
public bool Activo {get; set;}
public int Biblioteca {get; set;}

}

public class Prestamos{
    public int Id{get; set;}
    public DateTime Fecha_Inicio{get; set;}
    public DateTime Fecha_Fin{get; set;}
    public bool Activo{get; set;}
    public string? Estado{get; set;}
    public int Multa {get; set;}
    public int Usuario {get; set;}
    public int Biblioteca {get; set;}
    public int Libro {get; set;}


    public Multas _Multa {get; set;}
    public Usuarios _Usuario {get; set;}
    public Bibliotecas _Biblioteca {get; set;}
    public Libros _Libro {get; set;}
}

public class Autores: Personas{
public string? Nacionalidad{get; set;}

public List<Libros> Libro{get; set;}
}

public class Categorias{
    public int id {get; set;}
    public string? Nombre {get; set;}
    public string? Descripcion {get; set;}
    public bool Activo {get; set;}
}

public class Multas{
    public int id {get; set;}
    public decimal costo {get; set;}
    public DateTime Fecha {get; set;}
    public bool Activo {get; set;}
    
    public List<Libros> Libro{get; set;}
}