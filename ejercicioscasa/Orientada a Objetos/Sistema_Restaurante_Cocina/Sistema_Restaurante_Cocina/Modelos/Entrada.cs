using SistemaRestaurante.Enums;
using SistemaRestaurante.Interfaces;

namespace SistemaRestaurante.Modelos
{
    
    public class Entrada : Plato, IPreparable
    {
        public bool EsFria { get; set; }
        public int Porciones { get; set; }

        public Entrada(int id, string nombre, string descripcion,
                       decimal precioBase, TipoComida tipoComida,
                       NivelDificultad dificultad,
                       bool esFria, int porciones)
            : base(id, nombre, descripcion, precioBase, tipoComida, dificultad)
        {
            EsFria = esFria;
            Porciones = porciones;
        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            return EsFria ? TimeSpan.FromMinutes(10) : TimeSpan.FromMinutes(20);
        }

        public void GenerarOrdenCocina()
        {
            Console.WriteLine($"Preparar entrada: {Nombre}");
        }

        public decimal CalcularCostoTotal()
        {
            return PrecioBase * Porciones;
        }
    }
}