using System;
using System.Globalization;
namespace Ex6 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Qual é a cotação do dólar?");

            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar?");

            double dollar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = Conversor.Covert(cotacao, dollar);

            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
