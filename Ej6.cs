using System;

class NominaEmpleado
{
    static void Main()
    {
        // 1️⃣ Entrada de datos
        Console.Write("Nombre del empleado: ");
        string nombre = Console.ReadLine();

        Console.Write("Salario por hora: ");
        double salarioHora = double.Parse(Console.ReadLine());

        // 2️⃣ Horas trabajadas
        Console.Write("Horas trabajadas: ");
        double horasTrabajadas = double.Parse(Console.ReadLine());

        Console.Write("Horas extra trabajadas: ");
        double horasExtra = double.Parse(Console.ReadLine());

        // 3️⃣ Cálculo de salario bruto
        double salarioBruto = (horasTrabajadas * salarioHora) + (horasExtra * salarioHora * 1.5);

        // 4️⃣ Deducciones
        const double IMPUESTO = 0.10; // 10% de impuestos
        const double SEGURIDAD_SOCIAL = 0.05; // 5% seguridad social
        double deducciones = salarioBruto * (IMPUESTO + SEGURIDAD_SOCIAL);

        // 5️⃣ Salario neto
        double salarioNeto = salarioBruto - deducciones;

        // Mostrar resultados
        Console.WriteLine("\n--- Nómina ---");
        Console.WriteLine($"Empleado: {nombre}");
        Console.WriteLine($"Salario bruto: ${salarioBruto:F2}");
        Console.WriteLine($"Deducciones: ${deducciones:F2}");
        Console.WriteLine($"Salario neto: ${salarioNeto:F2}");
    }
}
