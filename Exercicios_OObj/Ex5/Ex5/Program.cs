using System;
using System.Globalization;

namespace Ex5 {
    class Program {
        static void Main(string[] args) {

            Aluno a = new Aluno();

            Console.WriteLine("Entre com a 1 NOTA");

            a.Nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com a 2 NOTA");
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com a 3 NOTA");

            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final: " + a.Resultado().ToString("F2", CultureInfo.InvariantCulture));

            if (a.Aprovado()) {

                Console.WriteLine("Aprovado");
            } else {

                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltam " + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " Pontos" );
            }

            
        }
    }
}
