using System;
using System.Collections.Generic;
using System.Text;

namespace ejerciciosorientar.ejerciciosclase
{
    public class ejercicio1
    {
        
        public class CuentaBancaria
        {
            public string Titular { get; set; }
            public decimal Saldo { get; private set; }

            public CuentaBancaria(string titular)
            {
                Titular = titular;
                Saldo = 0;
            }

            public void ConsultarSaldo()
            {
                Console.WriteLine($"\n✅ Saldo actual de {Titular}: ${Saldo:N2}");
            }

            public void Depositar(decimal cantidad)
            {
                if (cantidad > 0)
                {
                    Saldo += cantidad;
                    Console.WriteLine($"💰 Depósito exitoso por ${cantidad:N2}");
                }
                else
                {
                    Console.WriteLine("⚠️ La cantidad a depositar debe ser mayor a 0.");
                }
            }

            public void Retirar(decimal cantidad)
            {
                if (cantidad <= 0)
                {
                    Console.WriteLine("⚠️ Ingrese un monto válido mayor a 0.");
                }
                else if (cantidad > Saldo)
                {
                    Console.WriteLine("❌ Fondos insuficientes.");
                }
                else
                {
                    Saldo -= cantidad;
                    Console.WriteLine($"💸 Retiro exitoso por ${cantidad:N2}");
                }
            }
        }

     
        public void Ejecutar()
        {
            Console.WriteLine("=== SIMULADOR DE CAJERO AUTOMÁTICO ===");
            Console.Write("Ingrese el nombre del titular: ");
            string nombre = Console.ReadLine();

            CuentaBancaria cuenta = new CuentaBancaria(nombre);
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n--- MENÚ DE OPCIONES ---");
                Console.WriteLine("1. Consultar Saldo");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Retirar");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        cuenta.ConsultarSaldo();
                        break;
                    case "2":
                        Console.Write("Monto a depositar: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal dep)) cuenta.Depositar(dep);
                        break;
                    case "3":
                        Console.Write("Monto a retirar: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal ret)) cuenta.Retirar(ret);
                        break;
                    case "4":
                        salir = true;
                        Console.WriteLine("Sesión finalizada. ¡Tenga un buen día!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}