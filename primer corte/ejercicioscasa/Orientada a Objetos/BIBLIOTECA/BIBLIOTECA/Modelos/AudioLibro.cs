using BibliotecaDigital.Enums;
using BibliotecaDigital.Interfaces;

namespace BibliotecaDigital.Modelos
{
    public class AudioLibro : MaterialBiblioteca, IPrestable
    {
        public TimeSpan Duracion { get; set; }
        public string Narrador { get; set; }

        public AudioLibro(int id, string titulo, string autor, int año,
            TipoCategoria categoria, TimeSpan duracion, string narrador)
            : base(id, titulo, autor, año, categoria)
        {
            Duracion = duracion;
            Narrador = narrador;
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(10);
        }

        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine($"Préstamo de audiolibro '{Titulo}' generado.");
        }

        public decimal CalcularMultaPorRetraso(int dias)
        {
            return dias * 0.4m;
        }
    }
}