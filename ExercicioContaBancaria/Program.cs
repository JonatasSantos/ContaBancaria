using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            double valor;
            Console.Write("Entre o numero da conta: ");
            int nroconta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)? ");
            char opcao = char.Parse(Console.ReadLine());

            if (opcao == 's' || opcao == 'S')
            {
                Console.Write("\nEntre o valor de deposito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(nroconta, titular, valor);
            }
            else
            {
                conta = new ContaBancaria(nroconta, titular);
            }

            Console.WriteLine("\nDados da conta:\n" + conta);

            Console.Write("\nEntre um valor para deposito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(valor);
            Console.WriteLine("Dados da conta atualizados:\n" + conta);

            Console.Write("\nEntre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valor);
            Console.WriteLine("Dados da conta atualizados:\n" + conta);
        }
    }
}
