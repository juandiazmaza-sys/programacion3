using System;
using System.IO;

enum TipoEnvio
{
    Nacional = 0,
    Internacional = 1
}

class Paquete
{
    public int Guia { get; set; }
    public string Destinatario { get; set; }
    public double Peso { get; set; }
    public TipoEnvio Tipo { get; set; }

    public string ToCSV()
    {
        return $"{Guia};{Destinatario};{Peso};{Tipo}";
    }
}

class Program
{
    static string Ruta = "envios.csv";

    static void Main()
    {
        int Opcion;

        do
        {
            Console.WriteLine("\n--- SISTEMA GLOBALSHIP ---");
            Console.WriteLine("1. Nuevo Envio");
            Console.WriteLine("2. Ver Peso Total");
            Console.WriteLine("3. Buscar por Guia");
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
                    CrearEnvio();
                    break;
                case 2:
                    ReportePeso();
                    break;
                case 3:
                    BuscarPorGuia();
                    break;
            }

        } while (Opcion != 0);
    }

    static void CrearEnvio()
    {
        try
        {
            Console.Write("Guia: ");
            int Guia;

            if (!int.TryParse(Console.ReadLine(), out Guia))
            {
                Console.WriteLine("Valor invalido");
                return;
            }

            Console.Write("Destinatario: ");
            string Destinatario = Console.ReadLine();

            Console.Write("Peso: ");
            double Peso;

            if (!double.TryParse(Console.ReadLine(), out Peso))
            {
                Console.WriteLine("Valor invalido");
                return;
            }

            Console.Write("Tipo (0 Nacional, 1 Internacional): ");
            int Tipo;

            if (!int.TryParse(Console.ReadLine(), out Tipo))
            {
                Console.WriteLine("Valor invalido");
                return;
            }

            Paquete P = new Paquete
            {
                Guia = Guia,
                Destinatario = Destinatario,
                Peso = Peso,
                Tipo = (TipoEnvio)Tipo
            };

            File.AppendAllText(Ruta, P.ToCSV() + Environment.NewLine);

            Console.WriteLine("Envio guardado");
        }
        catch (Exception Ex)
        {
            Console.WriteLine("Error: " + Ex.Message);
        }
    }

    static void ReportePeso()
    {
        try
        {
            if (!File.Exists(Ruta))
            {
                Console.WriteLine("No hay datos");
                return;
            }

            double Total = 0;
            var Lineas = File.ReadAllLines(Ruta);

            foreach (var L in Lineas)
            {
                var D = L.Split(';');

                if (D.Length == 4)
                {
                    Total += double.Parse(D[2]);
                }
            }

            Console.WriteLine("Peso total: " + Total);
        }
        catch (Exception Ex)
        {
            Console.WriteLine("Error: " + Ex.Message);
        }
    }

    static void BuscarPorGuia()
    {
        try
        {
            if (!File.Exists(Ruta))
            {
                Console.WriteLine("No hay datos");
                return;
            }

            Console.Write("Guia: ");
            int Guia;

            if (!int.TryParse(Console.ReadLine(), out Guia))
            {
                Console.WriteLine("Valor invalido");
                return;
            }

            var Lineas = File.ReadAllLines(Ruta);

            foreach (var L in Lineas)
            {
                var D = L.Split(';');

                if (D.Length == 4 && int.Parse(D[0]) == Guia)
                {
                    Console.WriteLine("Encontrado");
                    Console.WriteLine("Guia: " + D[0]);
                    Console.WriteLine("Destinatario: " + D[1]);
                    Console.WriteLine("Peso: " + D[2]);
                    Console.WriteLine("Tipo: " + D[3]);
                    return;
                }
            }

            Console.WriteLine("No encontrado");
        }
        catch (Exception Ex)
        {
            Console.WriteLine("Error: " + Ex.Message);
        }
    }
}