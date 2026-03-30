using System;
using ejerciciosorientar.ejerciciosclase; 

class Program
{
    static void Main(string[] args)
    {
        ejercicio1 eje1 = new ejercicio1();
        ejercicio2 eje2 = new ejercicio2();
        ejercicio3 eje3 = new ejercicio3();

        Console.WriteLine("--- Menú de Repaso ---");
        Console.WriteLine("Seleccione un ejercicio (1-3):");
        Console.WriteLine("1. Simulador de Cajero");
        Console.WriteLine("2. Control de Inventario");
        Console.WriteLine("3. Calculadora de Calificaciones");

        string opcion = Console.ReadLine();

        Console.Clear(); 

        switch (opcion)
        {
            case "1":
                eje1.Ejecutar();
                break;
            case "2":
                eje2.Ejecutar();
                break;
            case "3":
                eje3.Ejecutar();
                break;
            default:
                Console.WriteLine("❌ Opción no válida. Intente de nuevo.");
                break;
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}