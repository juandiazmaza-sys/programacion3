namespace CUENTA_BANCARIA
{
    public class CuentaBancaria
    {
        public string Titular { get; set; }
        public decimal Saldo { get; private set; }

        public CuentaBancaria(string titular, decimal saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void ConsultarSaldo() => Console.WriteLine($"\nSaldo: ${Saldo}");

        public void Depositar(decimal cantidad) { /* lógica */ }

        public void Retirar(decimal cantidad) { /* lógica */ }
    }
}