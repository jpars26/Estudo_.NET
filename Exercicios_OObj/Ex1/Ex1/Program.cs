using System;

namespace Ex1 {
    class Program {
        static void Main(string[] args) {
         

            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Entre com o nome da primeira pessoa e depois a idade");

            a.A = Console.ReadLine();
            a.B = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o nome da segunda pessoa e depois a idade");

            b.A = Console.ReadLine();
            b.B = int.Parse(Console.ReadLine());

            if(a.B > b.B) {
                Console.WriteLine("Pessoa mais velha: " + a.A);
            } else {
                Console.WriteLine("Pessoa mais velha: " + b.A);
            }
        }
    }
}
