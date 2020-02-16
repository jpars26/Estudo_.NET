using System;

namespace Ex5 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(" Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago: ");
            // 12 1 5.30
            // 16 2 5.10
            Console.WriteLine("Coloque as info da peca 1");
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int numpeca = int.Parse(vet[1]);
            double valor = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Coloque as info da peca 2");

            string[] vet2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vet2[0]);
            int numpeca2 = int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double resultado = (numpeca * valor) + (numpeca2 * valor2);

            Console.WriteLine("VALOR A PAGAR = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
