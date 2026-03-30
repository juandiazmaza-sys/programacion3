static void Main()
{
    Console.WriteLine("=== REGISTRO DE NUEVO PRODUCTO ===");
    Console.Write("Nombre del producto: ");
    string nombre = Console.ReadLine();
    Console.Write("Código: ");
    string codigo = Console.ReadLine();
    Console.Write("Precio: ");
    decimal precio = decimal.Parse(Console.ReadLine());
    Console.Write("Stock Inicial: ");
    int stock = int.Parse(Console.ReadLine());

    // Creamos la instancia del producto
    Producto miProducto = new Producto(nombre, codigo, precio, stock);

    int opcion;
    do
    {
        Console.WriteLine("\n--- GESTIÓN DE INVENTARIO ---");
        Console.WriteLine("1. Ver información del producto");
        Console.WriteLine("2. Entrada de mercancía (Agregar Stock)");
        Console.WriteLine("3. Salida de mercancía (Vender)");
        Console.WriteLine("4. Salir");
        Console.Write("Seleccione una opción: ");

        if (int.TryParse(Console.ReadLine(), out opcion))
        {
            switch (opcion)
            {
                case 1:
                    miProducto.MostrarInfo();
                    break;
                case 2:
                    Console.Write("Cantidad que entra al almacén: ");
                    int entrada = int.Parse(Console.ReadLine());
                    miProducto.AgregarStock(entrada);
                    break;
                case 3:
                    Console.Write("Cantidad a vender: ");
                    int venta = int.Parse(Console.ReadLine());
                    decimal totalVenta = miProducto.VenderProducto(venta);
                    if (totalVenta > 0)
                        Console.WriteLine($"Venta realizada. Total a cobrar: ${totalVenta:N2}");
                    break;
            }
        }
    } while (opcion != 4);
}