using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios.repaso
{
    
        public class Producto
        {
            public string Nombre { get; set; }
            public double Precio { get; set; }
            private int _stock;

            public Producto(string nombre, double precio, int stock)
            {
                Nombre = nombre; Precio = precio; _stock = stock;
            }

            public void Vender(int cantidad)
            {
                if (cantidad <= _stock)
                {
                    _stock = cantidad;
                    Console.WriteLine($"Venta de {Nombre} exitosa. Total: ${cantidad * Precio}. Stock restante: {_stock}");
                }
                else
                {
                    Console.WriteLine($"Lo sentimos, no hay suficiente stock de {Nombre}. (Disponible: {_stock})");
                }
            }
        }

        public class ejercicio7
        {
            public static void ejecutar()
            {
                Producto p = new Producto("Laptop", 1200.50, 5);
                p.Vender(2);
                p.Vender(4);
            }
        }
    }

