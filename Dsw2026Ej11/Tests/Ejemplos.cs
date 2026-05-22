using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList lista = new CasoList();

        Alumno a1 = new Alumno(1, "Juan", 8.5);
        Alumno a2 = new Alumno(2, "Maria", 9.2);
        Alumno a3 = new Alumno(3, "Pedro", 7.8);

        // Agregar 3 alumnos a la lista
        lista.AgregarAlumno(a1);
        lista.AgregarAlumno(a2);
        lista.AgregarAlumno(a3);

        // Listar por consola los alumnos
        Console.WriteLine("Lista de alumnos:");
        foreach (Alumno alumno in lista.RetornarAlumno())
        {
            Console.WriteLine(alumno);
        }

        // Buscar por nombre un alumno que exista y mostrar por consola
        Alumno encontrado = lista.BuscarAlumno("Maria");

        if (encontrado != null)
        {
            Console.WriteLine("\nAlumno encontrado:");
            Console.WriteLine(encontrado);
        }

        // Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        Alumno inexistente = lista.BuscarAlumno("Carlos");

        if (inexistente == null)
        {
            Console.WriteLine("\nNo existe");
        }

        // Eliminar un alumno y listar por consola los alumnos
        lista.EliminarAlumno(a3);

        Console.WriteLine("\nLuego de eliminar a Pedro:");
        foreach (Alumno alumno in lista.RetornarAlumno())
        {
            Console.WriteLine(alumno);
        }

        // Eliminar el primer elemento de la lista y listar por consola los alumnos
        lista.EliminarAlumnoPosicion(0);

        Console.WriteLine("\nLuego de eliminar el primer elemento:");
        foreach (Alumno alumno in lista.RetornarAlumno())
        {
            Console.WriteLine(alumno);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary diccionario = new CasoDictionary();

        Alumno a1 = new Alumno(1, "Juan", 8.5);
        Alumno a2 = new Alumno(2, "Maria", 9.2);
        Alumno a3 = new Alumno(3, "Pedro", 7.8);

        // Agregar 3 alumnos al diccionario
        diccionario.AgregarAlumno(a1);
        diccionario.AgregarAlumno(a2);
        diccionario.AgregarAlumno(a3);

        //Listar por consola los alumnos
        Console.WriteLine("Lista de alumnos:");
        foreach (var alumno in diccionario.RetornarDiccionario().Values)
        {
            Console.WriteLine(alumno);
        }

        //Buscar un alumno por clave y mostrar por consola
        Alumno? encontrado = diccionario.BuscarAlumno(2);

        if (encontrado != null)
        {
            Console.WriteLine("\nAlumno encontrado:");
            Console.WriteLine(encontrado);
        }

        //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
        Alumno? inexistente = diccionario.BuscarAlumno(10);

        if (inexistente == null)
        {
            Console.WriteLine("\nNo existe");
        }

        //Eliminar un alumno por clave y listar por consola los alumnos
        diccionario.EliminarAlumno(3);

        Console.WriteLine("\nLuego de eliminar al alumno con ID 3:");
        foreach (var alumno in diccionario.RetornarDiccionario().Values)
        {
            Console.WriteLine(alumno);
        }

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
