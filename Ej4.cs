//Descomponer el problema de gestionar un inventario de libros (registro, búsqueda, actualización y eliminación).


using System;
using System.Collections.Generic;

class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public double Precio { get; set; }
    public int Cantidad { get; set; }
}

class InventarioLibros
{
    static List<Libro> inventario = new List<Libro>();

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n==== INVENTARIO DE LIBROS ====");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Buscar libro");
            Console.WriteLine("3. Actualizar libro");
            Console.WriteLine("4. Eliminar libro");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: RegistrarLibro(); break;
                case 2: BuscarLibro(); break;
                case 3: ActualizarLibro(); break;
                case 4: EliminarLibro(); break;
                case 5: Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opción inválida."); break;
            }
        } while (opcion != 5);
    }

    // 1️⃣ Registro
    static void RegistrarLibro()
    {
        Libro libro = new Libro();

        Console.Write("Título: ");
        libro.Titulo = Console.ReadLine();

        Console.Write("Autor: ");
        libro.Autor = Console.ReadLine();

        Console.Write("ISBN: ");
        libro.ISBN = Console.ReadLine();

        Console.Write("Precio: ");
        libro.Precio = double.Parse(Console.ReadLine());

        Console.Write("Cantidad: ");
        libro.Cantidad = int.Parse(Console.ReadLine());

        inventario.Add(libro);
        Console.WriteLine("✅ Libro registrado con éxito.");
    }

    // 2️⃣ Búsqueda
    static void BuscarLibro()
    {
        Console.Write("Ingrese el título o ISBN a buscar: ");
        string dato = Console.ReadLine();

        bool encontrado = false;
        foreach (var libro in inventario)
        {
            if (libro.Titulo.Contains(dato, StringComparison.OrdinalIgnoreCase) ||
                libro.ISBN.Equals(dato, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"\nTítulo: {libro.Titulo}");
                Console.WriteLine($"Autor: {libro.Autor}");
                Console.WriteLine($"ISBN: {libro.ISBN}");
                Console.WriteLine($"Precio: {libro.Precio}");
                Console.WriteLine($"Cantidad: {libro.Cantidad}");
                encontrado = true;
            }
        }

        if (!encontrado)
            Console.WriteLine("❌ Libro no encontrado.");
    }

    // 3️⃣ Actualización
    static void ActualizarLibro()
    {
        Console.Write("Ingrese el ISBN del libro a actualizar: ");
        string isbn = Console.ReadLine();

        Libro libro = inventario.Find(l => l.ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase));

        if (libro != null)
        {
            Console.Write("Nuevo precio: ");
            libro.Precio = double.Parse(Console.ReadLine());

            Console.Write("Nueva cantidad: ");
            libro.Cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("✅ Datos actualizados.");
        }
        else
        {
            Console.WriteLine("❌ Libro no encontrado.");
        }
    }

    // 4️⃣ Eliminación
    static void EliminarLibro()
    {
        Console.Write("Ingrese el ISBN del libro a eliminar: ");
        string isbn = Console.ReadLine();

        Libro libro = inventario.Find(l => l.ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase));

        if (libro != null)
        {
            inventario.Remove(libro);
            Console.WriteLine("✅ Libro eliminado.");
        }
        else
        {
            Console.WriteLine("❌ Libro no encontrado.");
        }
    }
}
