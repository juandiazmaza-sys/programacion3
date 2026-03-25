

using System;

namespace ejerciciosPOO.ejercicios
{
    public abstract class CuentaBancaria
    {
        public string Titular { get; set; }
        public decimal Saldo { get; protected set; }

        public abstract void Retirar(decimal monto);

        public void Depositar(decimal monto)
        {
            if (monto > 0)
            {
                Saldo += monto;
                Console.WriteLine($"Depositado: ${monto}. Nuevo Saldo: ${Saldo}");
            }
            else
            {
                Console.WriteLine("Error: El depósito debe ser mayor a 0.");
            }
        }
    }

    public class CuentaAhorros : CuentaBancaria
    {
        public override void Retirar(decimal monto)
        {
            if (Saldo >= monto)
            {
                Saldo -= monto;
                Console.WriteLine($"Retirado: ${monto}. Nuevo Saldo: ${Saldo}");
            }
            else
            {
                Console.WriteLine("Error: Saldo insuficiente en Cuenta de Ahorros.");
            }
        }
    }

    public class CuentaCorriente : CuentaBancaria
    {
        private const decimal SobregiroPermitido = 500;

        public override void Retirar(decimal monto)
        {
            if (Saldo + SobregiroPermitido >= monto)
            {
                Saldo -= monto;
                Console.WriteLine($"Retirado: ${monto}. Nuevo Saldo: ${Saldo} (Uso de sobregiro)");
            }
            else
            {
                Console.WriteLine("Error: Excede el límite de sobregiro.");
            }
        }
    }

    public static class EjemploBanco
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- EJERCICIO 2: SIMULADOR BANCARIO ---");
            CuentaBancaria ahorros = new CuentaAhorros { Titular = "Carlos" };
            ahorros.Depositar(1000);
            ahorros.Retirar(1200);

            CuentaBancaria corriente = new CuentaCorriente { Titular = "Marta" };
            corriente.Depositar(100);
            corriente.Retirar(400);
        }
    }
}
