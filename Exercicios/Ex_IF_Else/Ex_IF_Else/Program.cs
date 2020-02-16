using System;

namespace Ex_IF_Else {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(" Ler um número inteiro, e depois dizer se este número é negativo ou não: ");

            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());


            if (num % num2 == 0 || num2 % num == 0) {
                Console.WriteLine("Multiplos");
            } else {

                Console.WriteLine("Não são Multiplos");
            }
        }
    }
}
