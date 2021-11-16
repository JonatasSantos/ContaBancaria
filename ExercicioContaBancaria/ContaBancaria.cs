using System.Globalization;

namespace ExercicioContaBancaria
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(){}

        public ContaBancaria(int nroconta, string titular)
        {
            Numero = nroconta;
            Titular = titular;
            Saldo = 0.0;
        }

        public ContaBancaria(int nroconta, string titular, double saldo)
        {
            Numero = nroconta;
            Titular = titular;
            Saldo = saldo;
        }
            
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Numero
                + ", Titular: " + Titular
                + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
