using System;
using System.Collections.Generic;
using System.Text;

namespace ejerciciosorientar.ejerciciosclase
{
    public class ejercicio2
    {
        public class Producto
        {
           
            public string Nombre { get; set; }
            public string Codigo { get; set; }
            public decimal Precio { get; set; }
            public int CantidadStock { get; private set; }

            public Producto(string nombre, string codigo, decimal precio, int stockInicial)
            {
                Nombre = nombre;
                Codigo = codigo;
                Precio = precio;
                CantidadStock = stockInicial;
            }

            
            public void AgregarStock(int cantidad)
            {
                if (cantidad > 0)
                {
                    CantidadStock += cantidad;
                    Console.WriteLine($"📦 Se han añadido {cantidad} unidades. Nuevo stock: {CantidadStock}");
                }
                else
                {
                    Console.WriteLine("⚠️ La cantidad a añadir debe ser mayor a cero.");
                }
            }

            public decimal VenderProducto(int cantidad)
            {
                if (cantidad <= 0)
                {
                    Console.WriteLine("⚠️ La cantidad a vender debe ser mayor a cero.");
                    return 0;
                }

                if (cantidad > CantidadStock)
                {
                    Console.WriteLine($"❌ Error: Solo quedan {CantidadStock} unidades disponibles.");
                    return 0;
                }

                CantidadStock -= cantidad;
                decimal total = Precio * cantidad;
                Console.WriteLine($"✅ Venta realizada. Total a cobrar: ${total:N2}");
                return total;
            }

            public void MostrarInfo()
            {
                Console.WriteLine("\n--- DETALLES DEL PRODUCTO ---");
                Console.WriteLine($"Código: {Codigo}");
                Console.WriteLine($"Producto: {Nombre}");
                Console.WriteLine($"Precio Unitario: ${Precio:N2}");
                Console.WriteLine($"Stock Disponible: {CantidadStock} unidades");
                Console.WriteLine("------------------------------");
            }
        }

        public void Ejecutar()
        {
            Console.WriteLine("=== SISTEMA DE CONTROL DE INVENTARIO ===");

           
            Console.Write("Nombre del producto: ");
            string nom = Console.ReadLine();
            Console.Write("Código: ");
            string cod = Console.ReadLine();
            Console.Write("Precio: ");
            decimal.TryParse(Console.ReadLine(), out decimal pre);
            Console.Write("Stock inicial: ");
            int.TryParse(Console.ReadLine(), out int stock);

            Producto miProd = new Producto(nom, cod, pre, stock);

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\n--- MENÚ DE INVENTARIO ---");
                Console.WriteLine("1. Ver información del producto");
                Console.WriteLine("2. Agregar Stock (Entrada)");
                Console.WriteLine("3. Vender Producto (Salida)");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("Seleccione: ");

                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        miProd.MostrarInfo();
                        break;
                    case "2":
                        Console.Write("Cantidad que entra al almacén: ");
                        if (int.TryParse(Console.ReadLine(), out int cantAdd)) miProd.AgregarStock(cantAdd);
                        break;
                    case "3":
                        Console.Write("Cantidad a vender: ");
                        if (int.TryParse(Console.ReadLine(), out int cantVend)) miProd.VenderProducto(cantVend);
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}