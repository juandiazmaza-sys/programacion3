using System;
using System.IO;

class Program
{
    static void Main()
    {
        string archivo = "cumpleaños.txt";

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Fecha nacimiento (dd/MM/yyyy): ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());

            Amigo amigo = new Amigo(nombre, fecha);

            int dias = amigo.DiasParaCumple();

            Console.WriteLine($"A {nombre} le faltan {dias} días para su cumpleaños.");

            string linea = $"{nombre} - {fecha:dd/MM/yyyy}";
            File.AppendAllText(archivo, linea + Environment.NewLine);
        }

        Console.WriteLine("\nDatos guardados en cumpleaños.txt");
    }
}