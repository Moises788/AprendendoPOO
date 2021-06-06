using System;
using System.Globalization;

namespace Banco {
    class Program {
        static void Main(string[] args) {
            Conta conta;

            Console.WriteLine("Indique o seu nome:");
            string titular = Console.ReadLine();

            Console.WriteLine("Indique o seu número de usuário:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Deseja fazer saldo?");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 'n' || resp == 'N') {
                conta = new Conta(numero, titular);
            }
            else {
                Console.WriteLine("Informe o valor a ser depositado");
                double saldo = double.Parse(Console.ReadLine());
                conta = new Conta(numero, titular, saldo);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre com o valor do deposito:");
            conta.Deposito(double.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine("Entre com o valor de saque:");
            conta.Saque(double.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
        }

    }
}
