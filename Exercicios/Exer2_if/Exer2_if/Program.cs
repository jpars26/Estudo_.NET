using System;
using System.Globalization;

namespace Exer2_if {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(" leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.!");

            string[] vet = Console.ReadLine().Split();
            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);

            double resultado;
            if (codigo == 1) {

                resultado = quantidade * 4.00;

                Console.WriteLine("TOTAL: " + resultado.ToString("F2", CultureInfo.InvariantCulture));

            } else if (codigo == 2) {

                resultado = quantidade * 4.50;
                Console.WriteLine("TOTAL: " + resultado.ToString("F2", CultureInfo.InvariantCulture));

            } else if (codigo == 3) {

                resultado = quantidade * 5.00;
                Console.WriteLine("TOTAL: " + resultado.ToString("F2", CultureInfo.InvariantCulture));



            } else if (codigo == 4) {

                resultado = quantidade * 2.00;
                Console.WriteLine("TOTAL: " + resultado.ToString("F2", CultureInfo.InvariantCulture));



            } else if(codigo == 5) {

                resultado = quantidade * 1.50;
                Console.WriteLine("TOTAL: " + resultado.ToString("F2", CultureInfo.InvariantCulture));



            }
        }
    }
}
