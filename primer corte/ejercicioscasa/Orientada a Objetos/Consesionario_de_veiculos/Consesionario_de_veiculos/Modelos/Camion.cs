using System;
using ConcesionarioVehiculos.Enums;

namespace ConcesionarioVehiculos.Modelos
{
    public class Camion : Vehiculo
    {
        public int CapacidadCarga { get; set; }

        public Camion(string marca, string modelo, int año,
            TipoCombustible combustible, EstadoVehiculo estado,
            decimal precioBase, int capacidadCarga)
            : base(marca, modelo, año, combustible, estado, precioBase)
        {
            CapacidadCarga = capacidadCarga;
        }

        public override decimal CalcularPrecioVenta()
        {
            return PrecioBase * 1.15m; 
        }

        public override decimal CalcularComision()
        {
            return PrecioBase * 0.07m; 
        }
    }
}