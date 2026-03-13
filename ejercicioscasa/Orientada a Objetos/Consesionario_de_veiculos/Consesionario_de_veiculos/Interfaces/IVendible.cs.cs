using System;
namespace ConcesionarioVehiculos.Interfaces
{
    public interface IVendible
    {
        decimal CalcularPrecioVenta();
        decimal CalcularComision();
    }
}