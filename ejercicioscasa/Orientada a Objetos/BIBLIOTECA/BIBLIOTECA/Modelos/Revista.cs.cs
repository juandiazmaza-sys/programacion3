using BibliotecaDigital.Enums;
using BibliotecaDigital.Interfaces;

namespace BibliotecaDigital.Modelos
{
    public class Revista : MaterialBiblioteca, IPrestable
    {
        public int NumeroEdicion { get; set; }
        public string Periodicidad { get; set; }

        public Revista(int id, string titulo, string autor, int año,
            TipoCategoria categoria, int edicion, string periodicidad)
            : base(id, titulo, autor, año, categoria)
        {
            NumeroEdicion = edicion;
            Periodicidad = periodicidad;
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(7);
        }

        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine($"Préstamo de revista '{Titulo}' generado.");
        }

        public decimal CalcularMultaPorRetraso(int dias)
        {
            return dias * 0.3m;
        }
    }
}