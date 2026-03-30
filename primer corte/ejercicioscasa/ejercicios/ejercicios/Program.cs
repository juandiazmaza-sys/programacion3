using ejercicios.repaso;
using static ejercicios.repaso.ejercicio2;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Menú de Repaso ---");
            Console.WriteLine("Seleccione un ejercicio (1-5):");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    ejercicio1.ejecutar();
                    break;
                case "2":
                    ejercicio2.ejecutar();
                    break;
                case "3":
                    ejejrcicio3.ejecutar();
                    break;
                case "4":
                    ejercicio4.ejecutar();
                    break;
                case "5":
                    ejercicio5.ejecutar();
                    break;
                case "6":
                    ejercicio6.ejecutar();
                    break;
                case "7":
                    ejercicio7.ejecutar();
                    break;
                case "8":
                    ejercico8.ejecutar();
                    break;
                case "9":
                    ejercicio9.ejecutar();
                    break;
                case "10":
                    ejercicio10.ejecutar();
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
