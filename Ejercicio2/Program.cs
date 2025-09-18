using System;

class FacturaSupermercado
{
    static void Main()
    {
        
        Console.WriteLine("¿Cuántos productos compró? ");
        int cantidadProductos = int.Parse(Console.ReadLine()!);

        string[] nombres = new string[cantidadProductos];
        int[] cantidades = new int[cantidadProductos];
        double[] precios = new double[cantidadProductos];

        for (int i = 0; i < cantidadProductos; i++)
        {
            Console.Write("Nombre del producto " + (i + 1) + ": ");
            nombres[i] = Console.ReadLine()!;

            Console.Write("Cantidad de " + nombres[i] + ": ");
            cantidades[i] = int.Parse(Console.ReadLine()!);

            Console.Write("Precio unitario de " + nombres[i] + ": ");
            precios[i] = double.Parse(Console.ReadLine()!);
        }

        
        double subtotal = 0;
        for (int i = 0; i < cantidadProductos; i++)
        {
            subtotal += cantidades[i] * precios[i];
        }


        double impuesto = subtotal * 0.15; // 15 % de impuesto
        double total = subtotal + impuesto;

        Console.WriteLine("\nFactura:");
        Console.WriteLine("Producto\tCantidad\tPrecio Unitario\tTotal");
        for (int i = 0; i < cantidadProductos; i++)
        {
            double totalProducto = cantidades[i] * precios[i];
            Console.WriteLine($"{nombres[i]}\t\t{cantidades[i]}\t\t{precios[i]:C2}\t\t{totalProducto:C2}");
        }
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Subtotal: " + subtotal.ToString("C2"));
        Console.WriteLine("Impuesto (15%): " + impuesto.ToString("C2"));
        Console.WriteLine("Total a pagar: " + total.ToString("C2"));

        Console.ReadLine();
    }
}
