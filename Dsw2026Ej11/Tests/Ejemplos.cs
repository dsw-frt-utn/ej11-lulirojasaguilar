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

        // Agregar 3 alumnos
        lista.AgregarAlumno(a1);
        lista.AgregarAlumno(a2);
        lista.AgregarAlumno(a3);

        // Listar alumnos
        Console.WriteLine("Lista de alumnos:");
        foreach (Alumno alumno in lista.RetornarAlumno())
        {
            Console.WriteLine(alumno);
        }

        // Buscar alumno existente
        Alumno encontrado = lista.BuscarAlumno("Maria");

        if (encontrado != null)
        {
            Console.WriteLine("\nAlumno encontrado:");
            Console.WriteLine(encontrado);
        }

        // Buscar alumno inexistente
        Alumno inexistente = lista.BuscarAlumno("Carlos");

        if (inexistente == null)
        {
            Console.WriteLine("\nNo existe");
        }

        // Eliminar un alumno
        lista.EliminarAlumno(a3);

        Console.WriteLine("\nLuego de eliminar a Pedro:");
        foreach (Alumno alumno in lista.RetornarAlumno())
        {
            Console.WriteLine(alumno);
        }

        // Eliminar primer elemento
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

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
