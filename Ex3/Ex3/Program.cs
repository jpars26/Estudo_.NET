using System;

namespace Ex3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("a ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: ");

            //"DIFERENCA = (A * B - C * D). :"
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int diferenca = num1 * num2 - num3 * num4;

            Console.WriteLine("DIFERENÇA: " + diferenca);

        }
    }
}
