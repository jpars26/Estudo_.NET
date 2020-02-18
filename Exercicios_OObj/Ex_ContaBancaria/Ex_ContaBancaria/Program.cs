using System;
using System.Globalization;

namespace Ex_ContaBancaria {
    class Program {
        static void Main(string[] args) {

            Conta conta;

            Console.WriteLine("Entre o número da conta:");
            int numero = int.Parse( Console.ReadLine());

            Console.WriteLine("Entre o titular da conta:");
           string titular = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial(s / n) ? ");

            char resposta = char.Parse( Console.ReadLine());


            
            if (resposta == 's') {
                Console.WriteLine("Entre o valor de depósito inicial:");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, titular, depositoInicial);




            } else {

                conta = new Conta(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia); 
             

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.WriteLine("Entre com o valor do saque");
             quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
        }
    }
}
