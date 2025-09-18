// Analizar el problema de un cajero automático y dividirlo en subproblemas (inicio de sesión, consulta de saldo, retiro, depósito, cierre de sesión).

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Contraseña = "Duran2025";
            double saldo = 1500.00;

            Console.WriteLine("Bienvenido al Cajero Automático");
            Console.Write("Por favor, ingrese su contraseña: ");
            string inputContraseña = Console.ReadLine()!;

            while (Contraseña != inputContraseña)
            {
                Console.WriteLine("Contraseña incorrecta. Intente de nuevo.");
                Console.Write("Ingrese su contraseña: ");
                inputContraseña = Console.ReadLine()!;
            }
            Console.WriteLine("Inicio de sesión exitoso.");

            int Opcion;
            do
            {
                Console.WriteLine(" -----------------------------");
                Console.WriteLine("| 1. Consultar saldo, 2. Retiro, 3. Deposito, 4. Cierre Sesion (Seleccione un numero)|");
                Opcion = int.Parse(Console.ReadLine()!);

                switch (Opcion)
                {
                    case 1:
                        Random rnd = new Random();
                        double saldoRandom = rnd.Next(0, 10000);
                        Console.WriteLine($"Su saldo actual es: {saldoRandom:C2}");
                        break;
                    case 2:
                        Console.Write("Ingrese la cantidad a retirar: ");
                        double retiro = double.Parse(Console.ReadLine()!);
                        if (retiro > saldo)
                        {
                            Console.WriteLine("Fondos insuficientes para este retiro.");
                        }
                        else
                        {
                            saldo -= retiro;
                            Console.WriteLine($"Retiro exitoso. Su nuevo saldo es: {saldo:C2}");
                        }
                        break;
                    case 3:
                        Console.Write("Ingrese la cantidad a depositar: ");
                        double deposito = double.Parse(Console.ReadLine()!);
                        saldo += deposito;
                        Console.WriteLine($"Depósito exitoso. Su nuevo saldo es: {saldo:C2}");
                        break;
                    case 4:
                        Console.WriteLine("Cierre de sesión exitoso. Gracias por usar el cajero automático.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 4.");
                        break;
                }
            } while (Opcion != 4);
        }
    }
}
