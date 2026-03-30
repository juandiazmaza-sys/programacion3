using System;
using System.IO;

interface ICobrable
{
    int CalcularTarifa(int Minutos);
}

abstract class Vehiculo
{
    public string Placa { get; set; }
    public string Marca { get; set; }

    public abstract string MostrarDatos();
}

class Carro : Vehiculo, ICobrable
{
    public int NroPuertas { get; set; }

    public override string MostrarDatos()
    {
        return $"CARRO MARCA {Marca} - PUERTAS: {NroPuertas}";
    }

    public int CalcularTarifa(int Minutos)
    {
        return Minutos * 100;
    }
}

class Moto : Vehiculo, ICobrable
{
    public int Cilindraje { get; set; }

    public override string MostrarDatos()
    {
        return $"MOTO MARCA {Marca} - CILINDRAJE: {Cilindraje}";
    }

    public int CalcularTarifa(int Minutos)
    {
        return Minutos * 50;
    }
}

class Program
{
    static Vehiculo[] Parqueadero = new Vehiculo[5];
    static int Contador = 0;

    static void Main()
    {
        int Opcion;

        do
        {
            Console.WriteLine("\n--- MENU PARKINGPRO ---");
            Console.WriteLine("1. Registrar Vehiculo");
            Console.WriteLine("2. Consultar por Placa");
            Console.WriteLine("3. Ver todos");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione: ");

            if (!int.TryParse(Console.ReadLine(), out Opcion))
            {
                Console.WriteLine("Entrada invalida");
                continue;
            }

            switch (Opcion)
            {
                case 1:
                    RegistrarVehiculo();
                    break;
                case 2:
                    BuscarPorPlaca();
                    break;
                case 3:
                    ListarVehiculos();
                    break;
            }

        } while (Opcion != 0);
    }

    static void RegistrarVehiculo()
    {
        if (Contador >= Parqueadero.Length)
        {
            Console.WriteLine("Parqueadero lleno");
            return;
        }

        Console.Write("Tipo (1=Carro, 2=Moto): ");
        int Tipo;

        if (!int.TryParse(Console.ReadLine(), out Tipo))
        {
            Console.WriteLine("Valor invalido");
            return;
        }

        Console.Write("Placa: ");
        string Placa = Console.ReadLine().ToUpper();

        Console.Write("Marca: ");
        string Marca = Console.ReadLine().ToUpper();

        if (Tipo == 1)
        {
            Console.Write("Numero de puertas: ");
            int Puertas;

            if (!int.TryParse(Console.ReadLine(), out Puertas))
            {
                Console.WriteLine("Valor invalido");
                return;
            }

            Parqueadero[Contador] = new Carro
            {
                Placa = Placa,
                Marca = Marca,
                NroPuertas = Puertas
            };
        }
        else if (Tipo == 2)
        {
            Console.Write("Cilindraje: ");
            int Cilindraje;

            if (!int.TryParse(Console.ReadLine(), out Cilindraje))
            {
                Console.WriteLine("Valor invalido");
                return;
            }

            Parqueadero[Contador] = new Moto
            {
                Placa = Placa,
                Marca = Marca,
                Cilindraje = Cilindraje
            };
        }

        Contador++;
        Console.WriteLine("Vehiculo registrado");
    }

    static void BuscarPorPlaca()
    {
        Console.Write("Ingrese placa: ");
        string PlacaBuscada = Console.ReadLine().ToUpper();

        foreach (var V in Parqueadero)
        {
            if (V != null && V.Placa == PlacaBuscada)
            {
                ICobrable C = (ICobrable)V;
                int Tarifa = C.CalcularTarifa(60);

                Console.WriteLine("ENCONTRADO: " + V.MostrarDatos() + " - Tarifa: $" + Tarifa);
                return;
            }
        }

        Console.WriteLine("No encontrado");
    }

    static void ListarVehiculos()
    {
        foreach (var V in Parqueadero)
        {
            if (V != null)
            {
                Console.WriteLine(V.MostrarDatos().ToUpper());
            }
        }
    }
}