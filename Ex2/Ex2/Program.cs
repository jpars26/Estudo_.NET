using System;

namespace Ex2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais:  ");

            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14159

           double raio = pi * Math.Pow(raio, 2.0);

            Console.WriteLine("O resultado foi: " + raio);
        }
    }
}
