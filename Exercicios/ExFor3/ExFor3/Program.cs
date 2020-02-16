using System;
using System.Globalization;

namespace ExFor3 {
    class Program {
        static void Main(string[] args) {

            //Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            // de 3 valores reais, cada um deles com uma casa decimal.Apresente a média ponderada para cada um destes
            //conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.
            // é calculada multiplicando cada valor do conjunto de dados pelo seu peso. 
            //Depois, encontra-se a soma desses valores que será dividida pela soma dos pesos.
            Console.WriteLine("Digite o numero!!");

            int N = int.Parse(Console.ReadLine());
            double valor1, valor2, valor3;
            double resultado;


            for (int i = 0; i < N; i++) {

                string[] valor = Console.ReadLine().Split(' ');
                valor1 = double.Parse(valor[0], CultureInfo.InvariantCulture);
                valor2 = double.Parse(valor[1], CultureInfo.InvariantCulture);
                valor3 = double.Parse(valor[2], CultureInfo.InvariantCulture);

                resultado = ((valor1 * 2) + (valor2 * 3) + (valor3 * 5)) / 10;

                Console.WriteLine("O resultado sera: ");
                Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
            }

            
            
        }
    }
}
