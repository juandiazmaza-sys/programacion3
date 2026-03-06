internal class Producto
{
    private string? nombre;
    private string? codigo;
    private decimal precio;
    private int stock;

    public Producto(string? nombre, string? codigo, decimal precio, int stock)
    {
        this.nombre = nombre;
        this.codigo = codigo;
        this.precio = precio;
        this.stock = stock;
    }

    internal void AgregarStock(int entrada)
    {
        throw new NotImplementedException();
    }

    internal void MostrarInfo()
    {
        throw new NotImplementedException();
    }

    internal decimal VenderProducto(int venta)
    {
        throw new NotImplementedException();
    }
}