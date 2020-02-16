using System;

namespace Ex4 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(" leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário: ");


            int funcionarios = int.Parse(Console.ReadLine());
            double horas = double.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * valor;

            Console.WriteLine("Number = " + funcionarios);
            Console.WriteLine("Salary = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
