using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== PERFIL GAMER 🎮 ===");

        // Pedir Nick
        Console.Write("Ingresa tu Nick: ");
        string nick = Console.ReadLine();

        // Pedir Nivel
        int nivel;
        while (true)
        {
            Console.Write("Ingresa tu nivel de experiencia (1-100): ");
            if (int.TryParse(Console.ReadLine(), out nivel) && nivel >= 1 && nivel <= 100)
            {
                break;
            }
            Console.WriteLine("❗ Nivel inválido. Debe ser un número entre 1 y 100.");
        }

        // Pedir suscripción Premium
        bool premium;
        while (true)
        {
            Console.Write("¿Tienes suscripción Premium? (true/false): ");
            if (bool.TryParse(Console.ReadLine(), out premium))
            {
                break;
            }
            Console.WriteLine("❗ Respuesta inválida. Escribe 'true' o 'false'.");
        }

        // Determinar rango
        string rango = ObtenerRango(nivel);

        // Mostrar resultado
        Console.WriteLine("\n=== PERFIL CREADO ===");
        Console.WriteLine($"🎮 Bienvenido {nick}");
        Console.WriteLine($"Nivel: {nivel}");
        Console.WriteLine($"Rango: {rango}");

        if (premium)
        {
            Console.WriteLine("✨ Gracias por ser miembro Premium. ¡Tienes acceso exclusivo!");
        }
        else
        {
            Console.WriteLine("💡 Mejora a Premium para obtener beneficios especiales.");
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }

    static string ObtenerRango(int nivel)
    {
        if (nivel <= 20)
            return "Novato 🐣";
        else if (nivel <= 50)
            return "Jugador Intermedio ⚔️";
        else if (nivel <= 80)
            return "Jugador Avanzado 🔥";
        else
            return "Leyenda Gamer 👑";
    }
}