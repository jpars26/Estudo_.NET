using System;
using System.Globalization;
namespace Ex3 {
    class Program {
        static void Main(string[] args) {

            Retangulo r = new Retangulo();


            Console.WriteLine("Entre a largura e altura do retângulo: ");

            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(r);

        }
    }
}
