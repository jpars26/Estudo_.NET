using System;
using System.Globalization;

namespace Ex4 {
    class Program {
        static void Main(string[] args) {

            Funcionario f = new Funcionario();
            
            Console.WriteLine("Entre com o Nome");

            f.Nome = Console.ReadLine();

            Console.WriteLine("Entre com o Salario");

            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o Imposto");

            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + f);

            Console.WriteLine("Digite a quantidade para aumentar salario");

            double qte = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(qte);


            Console.WriteLine("Dados Atualizados = " + f);
        }
    }
}
