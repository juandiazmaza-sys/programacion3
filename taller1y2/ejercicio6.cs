using System;
using System.Collections.Generic;

namespace ejercicios.repaso
{
    
    public abstract class Mascota
    {
        public string Nombre { get; set; }
        public abstract void HacerTruco();
    }

    
    public class Loro : Mascota
    {
        public override void HacerTruco()
        {
            Console.WriteLine($"{Nombre} dice: ¡Quiero galleta!");
        }
    }

  
    public class Gato : Mascota
    {
        public override void HacerTruco()
        {
            Console.WriteLine($"{Nombre} está amasando pan en la manta...");
        }
    }

   
    public class ejercicio6
    {
        public static void ejecutar()
        {
            List<Mascota> misMascotas = new List<Mascota>
            {
                new Loro { Nombre = "Paco" },
                new Gato { Nombre = "Michi" }
            };

            Console.WriteLine("Elige una mascota para ver su truco:");
            Console.WriteLine("0. Loro");
            Console.WriteLine("1. Gato");

            if (int.TryParse(Console.ReadLine(), out int opcion) && opcion >= 0 && opcion < misMascotas.Count)
            {
                misMascotas[opcion].HacerTruco();
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
    }

  
    class Program
    {
        static void Main(string[] args)
        {
            ejercicio6.ejecutar();

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
