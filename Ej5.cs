//Diseñar subproblemas para un sistema de parqueo (entrada de vehículo, asignación de espacio, cobro por horas, salida).
using System;

class ParqueoSimple
{
    static void Main()
    {
        string placa;
        string tipo;
        DateTime horaEntrada;
        double monto;
        const double TARIFA_AUTO = 1.5;
        const double TARIFA_MOTO = 1.0;
        const double TARIFA_CAMION = 3.0;

        Console.WriteLine("=== Entrada de vehículo ===");
        Console.Write("Placa: ");
        placa = Console.ReadLine();
        Console.Write("Tipo (auto/moto/camion): ");
        tipo = Console.ReadLine().ToLower();
        horaEntrada = DateTime.Now;

        Console.WriteLine($"\nVehículo {placa} ingresó a las {horaEntrada}");

        // Simular tiempo de parqueo
        Console.Write("\nIngrese las horas estacionadas: ");
        double horas = double.Parse(Console.ReadLine());
        if (horas < 1) horas = 1;

        // Cobro
        switch (tipo)
        {
            case "auto": monto = horas * TARIFA_AUTO; break;
            case "moto": monto = horas * TARIFA_MOTO; break;
            case "camion": monto = horas * TARIFA_CAMION; break;
            default: monto = horas * TARIFA_AUTO; break;
        }

        // Salida
        Console.WriteLine($"\n=== Salida de vehículo ===");
        Console.WriteLine($"Placa: {placa}");
        Console.WriteLine($"Horas: {horas}");
        Console.WriteLine($"Monto a pagar: ${monto:F2}");
        Console.WriteLine("Gracias, vuelva pronto!");
    }
}
