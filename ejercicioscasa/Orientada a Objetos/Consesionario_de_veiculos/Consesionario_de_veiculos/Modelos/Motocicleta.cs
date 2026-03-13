using System;
using ConcesionarioVehiculos.Enums;

namespace ConcesionarioVehiculos.Modelos
{
    public class Motocicleta : Vehiculo
    {
        public int Cilindrada { get; set; }

        public Motocicleta(string marca, string modelo, int año,
            TipoCombustible combustible, EstadoVehiculo estado,
            decimal precioBase, int cilindrada)
            : base(marca, modelo, año, combustible, estado, precioBase)
        {
            Cilindrada = cilindrada;
        }

        public override decimal CalcularPrecioVenta()
        {
            return PrecioBase * 1.08m; 

        public override decimal CalcularComision()
        {
            return PrecioBase * 0.04m; 
        }
    }
}