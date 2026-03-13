using BibliotecaDigital.Enums;
using BibliotecaDigital.Interfaces;

namespace BibliotecaDigital.Modelos
{
    public class Libro : MaterialBiblioteca, IPrestable
    {
        public int NumeroPaginas { get; set; }
        public string ISBN { get; set; }

        public Libro(int id, string titulo, string autor, int año,
            TipoCategoria categoria, int paginas, string isbn)
            : base(id, titulo, autor, año, categoria)
        {
            NumeroPaginas = paginas;
            ISBN = isbn;
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(15);
        }

        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine($"Préstamo del libro '{Titulo}' generado.");
        }

        public decimal CalcularMultaPorRetraso(int dias)
        {
            return dias * 0.5m;
        }
    }
}
