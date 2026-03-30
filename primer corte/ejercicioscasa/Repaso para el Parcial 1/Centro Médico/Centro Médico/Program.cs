using System;
using System.IO;

enum Especialidad
{
    General = 0,
    Pediatria = 1,
    Odontologia = 2
}

interface IPrioritario
{
    double AplicarDescuento();
}

class CitaMedica : IPrioritario
{
    public string Paciente { get; set; }
    public Especialidad Especialidad { get; set; }
    public double CostoBase { get; set; }

    public double AplicarDescuento()
    {
        if (Especialidad == Especialidad.Pediatria)
        {
            return CostoBase * 0.8; 
        }
        return CostoBase;
    }

    public string ToCSV()
    {
        return $"{Paciente};{Especialidad};{CostoBase}";
    }
}

class Program
{
    static string ruta = "citas.csv";

    static void Main()
    {
        int opcion = -1;

        do
        {
            Console.WriteLine("\n--- MEDICAL MENU ---");
            Console.WriteLine("1. Agendar");
            Console.WriteLine("2. Facturar");
            Console.WriteLine("3. Cambiar Especialidad");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Entrada invalida");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    AgendarCita();
                    break;
                case 2:
                    VerFactura();
                    break;
                case 3:
                    CambiarEspecialidad();
                    break;
            }

        } while (opcion != 0);
    }

    static void AgendarCita()
    {
        try
        {
            Console.Write("Paciente: ");
            string paciente = Console.ReadLine();

            Console.Write("Especialidad (0: General, 1: Pediatria, 2: Odontologia): ");
            int tipo;
            if (!int.TryParse(Console.ReadLine(), out tipo))
            {
                Console.WriteLine("Valor invalido");
                return;
            }

            Console.Write("Costo base: ");
            double costo;
            if (!double.TryParse(Console.ReadLine(), out costo))
            {
                Console.WriteLine("Valor invalido");
                return;
            }

            CitaMedica cita = new CitaMedica
            {
                Paciente = paciente,
                Especialidad = (Especialidad)tipo,
                CostoBase = costo
            };

            File.AppendAllText(ruta, cita.ToCSV() + Environment.NewLine);

            Console.WriteLine("Cita guardada correctamente");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void VerFactura()
    {
        try
        {
            if (!File.Exists(ruta))
            {
                Console.WriteLine("No hay citas registradas");
                return;
            }

            Console.Write("Nombre del paciente: ");
            string nombre = Console.ReadLine();

            var lineas = File.ReadAllLines(ruta);

            foreach (var linea in lineas)
            {
                var datos = linea.Split(';');

                if (datos.Length == 3 && datos[0].Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    string especialidad = datos[1];
                    double costoBase = double.Parse(datos[2]);

                    CitaMedica cita = new CitaMedica
                    {
                        Paciente = datos[0],
                        Especialidad = (Especialidad)Enum.Parse(typeof(Especialidad), especialidad),
                        CostoBase = costoBase
                    };

                    double total = cita.AplicarDescuento();

                    Console.WriteLine("Paciente: " + cita.Paciente);
                    Console.WriteLine("Especialidad: " + cita.Especialidad);
                    Console.WriteLine("Costo Original: $" + cita.CostoBase);

                    if (cita.Especialidad == Especialidad.Pediatria)
                    {
                        Console.WriteLine("TOTAL A PAGAR (Con Desc. Pediatria): $" + total);
                    }
                    else
                    {
                        Console.WriteLine("TOTAL A PAGAR: $" + total);
                    }

                    return;
                }
            }

            Console.WriteLine("Paciente no encontrado");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void CambiarEspecialidad()
    {
        try
        {
            if (!File.Exists(ruta))
            {
                Console.WriteLine("No hay citas registradas");
                return;
            }

            Console.Write("Nombre del paciente: ");
            string nombre = Console.ReadLine();

            var lineas = File.ReadAllLines(ruta);

            for (int i = 0; i < lineas.Length; i++)
            {
                var datos = lineas[i].Split(';');

                if (datos.Length == 3 && datos[0].Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Nueva especialidad (0: General, 1: Pediatria, 2: Odontologia): ");
                    int nueva;
                    if (!int.TryParse(Console.ReadLine(), out nueva))
                    {
                        Console.WriteLine("Valor invalido");
                        return;
                    }

                    datos[1] = ((Especialidad)nueva).ToString();
                    lineas[i] = string.Join(";", datos);

                    File.WriteAllLines(ruta, lineas);

                    Console.WriteLine("Especialidad actualizada");
                    return;
                }
            }

            Console.WriteLine("Paciente no encontrado");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
