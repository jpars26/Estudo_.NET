using System;

namespace ExFor1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o numero e descubra todos os impares: ");

            int num = int.Parse(Console.ReadLine());
            int i ;
            for(i = 1; i <= num; i++) {

                if( i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
