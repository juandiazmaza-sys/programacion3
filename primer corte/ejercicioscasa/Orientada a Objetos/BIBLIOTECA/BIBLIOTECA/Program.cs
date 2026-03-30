using BibliotecaDigital.Enums;
using BibliotecaDigital.Interfaces;
using BibliotecaDigital.Modelos;

class Program
{
    static void Main()
    {
        List<IPrestable> materiales = new List<IPrestable>();

        int opcion = 0;

        do
        {
            Console.WriteLine("\n===== BIBLIOTECA DIGITAL =====");
            Console.WriteLine("1. Agregar Libro");
            Console.WriteLine("2. Agregar Revista");
            Console.WriteLine("3. Agregar AudioLibro");
            Console.WriteLine("4. Procesar Préstamos");
            Console.WriteLine("0. Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    Console.Write("Id: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Título: ");
                    string titulo = Console.ReadLine();

                    Console.Write("Autor: ");
                    string autor = Console.ReadLine();

                    Console.Write("Año: ");
                    int año = int.Parse(Console.ReadLine());

                    Console.WriteLine("Categoría (0 Ficcion,1 NoFiccion,2 Ciencia,3 Historia,4 Tecnologia)");
                    TipoCategoria cat = (TipoCategoria)int.Parse(Console.ReadLine());

                    Console.Write("Número de páginas: ");
                    int paginas = int.Parse(Console.ReadLine());

                    Console.Write("ISBN: ");
                    string isbn = Console.ReadLine();

                    Libro libro = new Libro(id, titulo, autor, año, cat, paginas, isbn);
                    materiales.Add(libro);

                    break;

                case 2:

                    Console.Write("Id: ");
                    int idR = int.Parse(Console.ReadLine());

                    Console.Write("Título: ");
                    string tituloR = Console.ReadLine();

                    Console.Write("Autor: ");
                    string autorR = Console.ReadLine();

                    Console.Write("Año: ");
                    int añoR = int.Parse(Console.ReadLine());

                    Console.WriteLine("Categoría:");
                    TipoCategoria catR = (TipoCategoria)int.Parse(Console.ReadLine());

                    Console.Write("Número de edición: ");
                    int edicion = int.Parse(Console.ReadLine());

                    Console.Write("Periodicidad: ");
                    string periodicidad = Console.ReadLine();

                    Revista revista = new Revista(idR, tituloR, autorR, añoR, catR, edicion, periodicidad);
                    materiales.Add(revista);

                    break;

                case 3:

                    Console.Write("Id: ");
                    int idA = int.Parse(Console.ReadLine());

                    Console.Write("Título: ");
                    string tituloA = Console.ReadLine();

                    Console.Write("Autor: ");
                    string autorA = Console.ReadLine();

                    Console.Write("Año: ");
                    int añoA = int.Parse(Console.ReadLine());

                    Console.WriteLine("Categoría:");
                    TipoCategoria catA = (TipoCategoria)int.Parse(Console.ReadLine());

                    Console.Write("Duración en minutos: ");
                    int minutos = int.Parse(Console.ReadLine());

                    Console.Write("Narrador: ");
                    string narrador = Console.ReadLine();

                    AudioLibro audio = new AudioLibro(
                        idA, tituloA, autorA, añoA, catA,
                        TimeSpan.FromMinutes(minutos),
                        narrador);

                    materiales.Add(audio);

                    break;

                case 4:

                    foreach (var material in materiales)
                    {
                        material.GenerarComprobantePrestramo();
                        Console.WriteLine("Fecha devolución: " + material.CalcularFechaDevolucion());
                        Console.WriteLine("Multa por 3 días retraso: " + material.CalcularMultaPorRetraso(3));
                        Console.WriteLine("-------------------");
                    }

                    break;
            }

        } while (opcion != 0);
    }
}
