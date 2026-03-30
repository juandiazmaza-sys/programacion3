using SistemaRestaurante.Enums;
using SistemaRestaurante.Interfaces;

namespace SistemaRestaurante.Modelos
{
    public class Postre : Plato, IPreparable
    {
        public bool ContieneLactosa { get; set; }
        public int CaloriasPorPorcion { get; set; }

        public Postre(int id, string nombre, string descripcion,
            decimal precioBase, TipoComida tipoComida,
            NivelDificultad dificultad,
            bool lactosa, int calorias)
            : base(id, nombre, descripcion, precioBase, tipoComida, dificultad)
        {
            ContieneLactosa = lactosa;
            CaloriasPorPorcion = calorias;
        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            int tiempo = 25 + (ContieneLactosa ? 5 : 0);
            return TimeSpan.FromMinutes(tiempo);
        }

        public void GenerarOrdenCocina()
        {
            Console.WriteLine($"Preparar postre: {Nombre}");
        }

        public decimal CalcularCostoTotal()
        {
            return PrecioBase;
        }
    }
}