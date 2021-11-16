using System.Globalization;

namespace ExercicioContaBancaria
{
    class ContaBancaria
    {
        private int _nroconta;
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(){}

        public ContaBancaria(int nroconta, string titular)
        {
            _nroconta = nroconta;
            Titular = titular;
            Saldo = 0.0;
        }

        public ContaBancaria(int nroconta, string titular, double saldo)
        {
            _nroconta = nroconta;
            Titular = titular;
            Saldo = saldo;
        }
            
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo = (Saldo - 5.00) - valor;
        }

        public override string ToString()
        {
            return "Conta " + _nroconta
                + ", Titular: " + Titular
                + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
