using SistemaRestaurante.Enums;
using SistemaRestaurante.Interfaces;
using SistemaRestaurante.Modelos;

class Program
{
    static void Main()
    {
      
        List<IPreparable> ordenes = new List<IPreparable>();

        int opcion = 0;

        do
        {
            try
            {
                Console.WriteLine("\n===== SISTEMA RESTAURANTE =====");
                Console.WriteLine("1. Registrar Entrada");
                Console.WriteLine("2. Registrar Plato Principal");
                Console.WriteLine("3. Registrar Postre");
                Console.WriteLine("4. Ver Ordenes");
                Console.WriteLine("0. Salir");

                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Console.Write("Id: ");
                        int idE = int.Parse(Console.ReadLine());

                        Console.Write("Nombre: ");
                        string nombreE = Console.ReadLine();

                        Console.Write("Descripción: ");
                        string descE = Console.ReadLine();

                        Console.Write("Precio Base: ");
                        decimal precioE = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Tipo comida (0 Vegetariana,1 Vegana,2 Carnivora,3 Mariscos,4 Mixta)");
                        TipoComida tipoE = (TipoComida)int.Parse(Console.ReadLine());

                        Console.WriteLine("Dificultad (0 Facil,1 Intermedio,2 Avanzado)");
                        NivelDificultad difE = (NivelDificultad)int.Parse(Console.ReadLine());

                        Console.Write("¿Es fría? (true/false): ");
                        bool fria = bool.Parse(Console.ReadLine());

                        Console.Write("Porciones: ");
                        int porciones = int.Parse(Console.ReadLine());

                        Entrada entrada = new Entrada(
                            idE, nombreE, descE, precioE,
                            tipoE, difE, fria, porciones
                        );

                        ordenes.Add(entrada);
                        break;

                    case 2:

                        Console.Write("Id: ");
                        int idP = int.Parse(Console.ReadLine());

                        Console.Write("Nombre: ");
                        string nombreP = Console.ReadLine();

                        Console.Write("Descripción: ");
                        string descP = Console.ReadLine();

                        Console.Write("Precio Base: ");
                        decimal precioP = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Tipo comida (0 Vegetariana,1 Vegana,2 Carnivora,3 Mariscos,4 Mixta)");
                        TipoComida tipoP = (TipoComida)int.Parse(Console.ReadLine());

                        Console.WriteLine("Dificultad (0 Facil,1 Intermedio,2 Avanzado)");
                        NivelDificultad difP = (NivelDificultad)int.Parse(Console.ReadLine());

                        Console.Write("Proteína principal: ");
                        string proteina = Console.ReadLine();

                        Console.Write("¿Incluye guarnición? (true/false): ");
                        bool guarnicion = bool.Parse(Console.ReadLine());

                        PlatoPrincipal plato = new PlatoPrincipal(
                            idP, nombreP, descP, precioP,
                            tipoP, difP, proteina, guarnicion
                        );

                        ordenes.Add(plato);
                        break;

                    case 3:

                        Console.Write("Id: ");
                        int idPo = int.Parse(Console.ReadLine());

                        Console.Write("Nombre: ");
                        string nombrePo = Console.ReadLine();

                        Console.Write("Descripción: ");
                        string descPo = Console.ReadLine();

                        Console.Write("Precio Base: ");
                        decimal precioPo = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Tipo comida (0 Vegetariana,1 Vegana,2 Carnivora,3 Mariscos,4 Mixta)");
                        TipoComida tipoPo = (TipoComida)int.Parse(Console.ReadLine());

                        Console.WriteLine("Dificultad (0 Facil,1 Intermedio,2 Avanzado)");
                        NivelDificultad difPo = (NivelDificultad)int.Parse(Console.ReadLine());

                        Console.Write("¿Contiene lactosa? (true/false): ");
                        bool lactosa = bool.Parse(Console.ReadLine());

                        Console.Write("Calorías por porción: ");
                        int calorias = int.Parse(Console.ReadLine());

                        Postre postre = new Postre(
                            idPo, nombrePo, descPo, precioPo,
                            tipoPo, difPo, lactosa, calorias
                        );

                        ordenes.Add(postre);
                        break;

                    case 4:

                        Console.WriteLine("\n=== ÓRDENES EN COCINA ===");

                        foreach (var orden in ordenes)
                        {
                            orden.GenerarOrdenCocina();

                            Console.WriteLine($"Tiempo preparación: {orden.CalcularTiempoPreparacion()}");

                            Console.WriteLine($"Costo total: {orden.CalcularCostoTotal()}");

                            Console.WriteLine("---------------------");
                        }

                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        } while (opcion != 0);
    }
}