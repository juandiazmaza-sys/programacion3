using CUENTA_BANCARIA;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== BIENVENIDO AL SIMULADOR DE CAJERO ===");
        Console.Write("Por favor, ingrese su nombre: ");
        string nombre = Console.ReadLine();

        // Creamos la cuenta con un saldo inicial de $0
        CuentaBancaria miCuenta = new CuentaBancaria(nombre, 0);

        int opcion;
        do
        {
            Console.WriteLine("\n--- MENÚ DE OPCIONES ---");
            Console.WriteLine("1. Consultar Saldo");
            Console.WriteLine("2. Depositar Dinero");
            Console.WriteLine("3. Retirar Dinero");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        miCuenta.ConsultarSaldo();
                        break;

                    case 2:
                        Console.Write("Monto a depositar: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal dep))
                            miCuenta.Depositar(dep);
                        break;

                    case 3:
                        Console.Write("Monto a retirar: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal ret))
                            miCuenta.Retirar(ret);
                        break;

                    case 4:
                        Console.WriteLine("Gracias por usar el cajero. ¡Hasta pronto!");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                opcion = 0;
            }

        } while (opcion != 4);
    }
}