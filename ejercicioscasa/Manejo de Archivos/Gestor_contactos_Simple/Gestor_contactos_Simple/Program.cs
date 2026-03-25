using System;
using System.IO;

class Contacto
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }

    public string ToCSV()
    {
        return $"{Nombre};{Telefono};{Correo}";
    }
}

class Program
{
    static void Main()
    {
        string ruta = "contactos.csv";

        // Solicitar datos
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Teléfono: ");
        string telefono = Console.ReadLine();

        Console.Write("Correo: ");
        string correo = Console.ReadLine();

        // Normalizar correo
        correo = correo.Trim().ToLower();

        // Crear objeto
        Contacto contacto = new Contacto
        {
            Nombre = nombre,
            Telefono = telefono,
            Correo = correo
        };

        // Confirmar guardado
        Console.Write("\n¿Deseas guardar el contacto? (si/no): ");
        string confirmar = Console.ReadLine().ToLower();

        if (confirmar == "si")
        {
            File.AppendAllText(ruta, contacto.ToCSV() + Environment.NewLine);
            Console.WriteLine("\n✅ Contacto guardado correctamente.");
        }
        else
        {
            Console.WriteLine("\n❌ Contacto NO guardado.");
        }

        // Preguntar si desea listar
        Console.Write("\n¿Deseas listar contactos? (si/no): ");
        string respuesta = Console.ReadLine().ToLower();

        if (respuesta == "si")
        {
            if (File.Exists(ruta))
            {
                Console.WriteLine("\n📋 Lista de contactos:\n");
                Console.WriteLine($"{"Nombre",-15} {"Teléfono",-15} {"Correo",-25}");
                Console.WriteLine("----------------------------------------------------------");

                var lineas = File.ReadAllLines(ruta);

                foreach (var linea in lineas)
                {
                    var datos = linea.Split(';');

                    if (datos.Length == 3)
                    {
                        Console.WriteLine($"{datos[0],-15} {datos[1],-15} {datos[2],-25}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No hay contactos guardados.");
            }
        }
    }
}