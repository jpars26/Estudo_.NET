using System;
using System.Globalization;
namespace Ex2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(" ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários!");

            Funcionario a, b;

            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: Nome e Salario");

            a.A = Console.ReadLine();
            a.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do primeiro funcionario: Nome e Salario");

            b.A = Console.ReadLine();
            b.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (a.B + b.B) / 2;

            Console.WriteLine("Salario Medio: " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
