using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Modelos;

namespace ConcesionarioVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== SISTEMA CONCESIONARIO =====");
            Console.WriteLine("1. Registrar Auto");
            Console.WriteLine("2. Registrar Motocicleta");
            Console.WriteLine("3. Registrar Camion");

            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Año: ");
            int año = int.Parse(Console.ReadLine());

            Console.WriteLine("Tipo Combustible:");
            Console.WriteLine("0 = Gasolina");
            Console.WriteLine("1 = Diesel");
            Console.WriteLine("2 = Electrico");
            Console.WriteLine("3 = Hibrido");
            TipoCombustible combustible =
                (TipoCombustible)int.Parse(Console.ReadLine());

            Console.WriteLine("Estado Vehiculo:");
            Console.WriteLine("0 = Nuevo");
            Console.WriteLine("1 = Usado");
            Console.WriteLine("2 = Seminuevo");
            EstadoVehiculo estado =
                (EstadoVehiculo)int.Parse(Console.ReadLine());

            Console.Write("Precio Base: ");
            decimal precioBase = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\n===== RESULTADO =====");

            switch (opcion)
            {
                case 1:

                    Console.Write("Número de puertas: ");
                    int puertas = int.Parse(Console.ReadLine());

                    Auto auto = new Auto(
                        marca, modelo, año,
                        combustible, estado,
                        precioBase, puertas
                    );

                    auto.MostrarInfo();
                    Console.WriteLine($"Precio Venta: {auto.CalcularPrecioVenta()}");
                    Console.WriteLine($"Comisión: {auto.CalcularComision()}");

                    break;

                case 2:

                    Console.Write("Cilindrada: ");
                    int cilindrada = int.Parse(Console.ReadLine());

                    Motocicleta moto = new Motocicleta(
                        marca, modelo, año,
                        combustible, estado,
                        precioBase, cilindrada
                    );

                    moto.MostrarInfo();
                    Console.WriteLine($"Precio Venta: {moto.CalcularPrecioVenta()}");
                    Console.WriteLine($"Comisión: {moto.CalcularComision()}");

                    break;

                case 3:

                    Console.Write("Capacidad de carga (kg): ");
                    int carga = int.Parse(Console.ReadLine());

                    Camion camion = new Camion(
                        marca, modelo, año,
                        combustible, estado,
                        precioBase, carga
                    );

                    camion.MostrarInfo();
                    Console.WriteLine($"Precio Venta: {camion.CalcularPrecioVenta()}");
                    Console.WriteLine($"Comisión: {camion.CalcularComision()}");

                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            Console.ReadKey();
        }
    }
}