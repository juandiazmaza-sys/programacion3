 using ConcesionarioVehiculos.Enums;

namespace ConcesionarioVehiculos.Modelos
{
    public class Auto : Vehiculo
    {
        public int NumeroPuertas { get; set; }

        public Auto(string marca, string modelo, int año,
            TipoCombustible combustible, EstadoVehiculo estado,
            decimal precioBase, int numeroPuertas)
            : base(marca, modelo, año, combustible, estado, precioBase)
        {
            NumeroPuertas = numeroPuertas;
        }

        public override decimal CalcularPrecioVenta()
        {
            return PrecioBase * 1.10m; 
        }

        public override decimal CalcularComision()
        {
            return PrecioBase * 0.05m; 
        }
    }
}