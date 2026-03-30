using SistemaRestaurante.Enums;
using SistemaRestaurante.Interfaces;

namespace SistemaRestaurante.Modelos
{
    public class PlatoPrincipal : Plato, IPreparable
    {
        public string ProteinaPrincipal { get; set; }
        public bool IncluyeGuarnicion { get; set; }

        public PlatoPrincipal(int id, string nombre, string descripcion,
            decimal precioBase, TipoComida tipoComida,
            NivelDificultad dificultad,
            string proteina, bool guarnicion)
            : base(id, nombre, descripcion, precioBase, tipoComida, dificultad)
        {
            ProteinaPrincipal = proteina;
            IncluyeGuarnicion = guarnicion;
        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            int tiempoBase = 30;
            int dificultadExtra = (int)Dificultad * 15;
            return TimeSpan.FromMinutes(tiempoBase + dificultadExtra);
        }

        public void GenerarOrdenCocina()
        {
            Console.WriteLine($"Preparar plato principal: {Nombre}");
        }

        public decimal CalcularCostoTotal()
        {
            return IncluyeGuarnicion ? PrecioBase + 5 : PrecioBase;
        }
    }
}