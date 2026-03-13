using SistemaRestaurante.Enums;

namespace SistemaRestaurante.Modelos
{
    s
    public abstract class Plato
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioBase { get; set; }
        public TipoComida TipoComida { get; set; }
        public NivelDificultad Dificultad { get; set; }

        
        protected Plato(int id, string nombre, string descripcion,
                        decimal precioBase, TipoComida tipoComida,
                        NivelDificultad dificultad)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioBase = precioBase;
            TipoComida = tipoComida;
            Dificultad = dificultad;
        }

      
        public virtual void MostrarInformacionNutricional()
        {
            Console.WriteLine("Información nutricional básica del plato.");
        }
    }
}