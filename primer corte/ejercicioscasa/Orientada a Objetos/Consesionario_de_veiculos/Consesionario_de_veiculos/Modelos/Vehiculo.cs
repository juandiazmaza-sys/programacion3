using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Interfaces;

namespace ConcesionarioVehiculos.Modelos
{
    public abstract class Vehiculo : IVendible
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public TipoCombustible Combustible { get; set; }
        public EstadoVehiculo Estado { get; set; }
        public decimal PrecioBase { get; set; }

        public Vehiculo(string marca, string modelo, int año,
                        TipoCombustible combustible,
                        EstadoVehiculo estado,
                        decimal precioBase)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Combustible = combustible;
            Estado = estado;
            PrecioBase = precioBase;
        }

        public abstract decimal CalcularPrecioVenta();
        public abstract decimal CalcularComision();

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Año}");
            Console.WriteLine($"Combustible: {Combustible}");
            Console.WriteLine($"Estado: {Estado}");
        }
    }
}