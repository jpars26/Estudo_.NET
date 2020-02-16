using System;
using System.Globalization;

namespace Segundo {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine(" leia três valores com ponto flutuante de dupla precisão: A, B e C.: ");
            // 3.0 4.0 5.2
            //a) a área do triângulo retângulo que tem A por base e C por altura.
            //b) a área do círculo de raio C. (pi = 3.14159)
            //c) a área do trapézio que tem A e B por bases e C por altura.
            //d) a área do quadrado que tem lado B.
            //e) a área do retângulo que tem lados A e B.

            Console.WriteLine("Entre com os valores: ");
            string[] valores = Console.ReadLine().Split(' ');
            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double pi = 3.14159;

            double triangulo = A * C / 2.0;
            double raio = pi * Math.Pow(C, 2);
            double trapezio = A * B / 2.0 * C;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine("Os resultados são: ");
            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + raio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}
