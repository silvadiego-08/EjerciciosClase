using System;

class ProgramaCalificaciones
{
    static void Main()
    {
        Console.WriteLine("¿Cuántos alumnos hay? ");
        int cantidad = int.Parse(Console.ReadLine()!);

        double suma = 0;
        int aprobados = 0;

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Calificación del alumno " + i + ": ");
            double cal = double.Parse(Console.ReadLine()!);

            suma = suma + cal;

            if (cal >= 60)
            {
                aprobados = aprobados + 1;
            }
        }

        double promedio = suma / cantidad;

        Console.WriteLine($"Promedio de la clase: {promedio:F2}");
        Console.WriteLine("Número de aprobados: " + aprobados);
        Console.WriteLine("Número de reprobados: " + (cantidad - aprobados));

        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
