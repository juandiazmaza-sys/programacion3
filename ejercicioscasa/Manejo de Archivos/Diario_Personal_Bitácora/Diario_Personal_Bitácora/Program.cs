using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string ruta = "diario.txt";

        // Mostrar últimas 3 líneas si el archivo existe
        if (File.Exists(ruta))
        {
            Console.WriteLine("📖 Últimas entradas del diario:\n");

            var lineas = File.ReadAllLines(ruta);

            foreach (var linea in lineas.TakeLast(3))
            {
                Console.WriteLine(linea);
            }

            Console.WriteLine("\n----------------------------\n");
        }

        // Solicitar nombre
        Console.Write("Ingresa tu nombre: ");
        string usuario = Console.ReadLine();

        // Solicitar mensaje
        Console.Write("Escribe tu pensamiento o actividad del día: ");
        string mensaje = Console.ReadLine();

        // Obtener fecha y hora actual
        string fechaHora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        // Formato de la línea
        string entrada = $"[{fechaHora}] - {usuario}: {mensaje}\n";

        // Guardar sin sobrescribir
        File.AppendAllText(ruta, entrada);

        Console.WriteLine("\n✅ Entrada guardada correctamente.");
    }
}
