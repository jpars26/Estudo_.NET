using System;

namespace ExFor2 {
    class Program {
        static void Main(string[] args) {

            //Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            //Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
           // essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

            Console.WriteLine("Digite um valor!");

            int N = int.Parse(Console.ReadLine());
            int aux;
            int dentro = 0;
            int fora = 0;
            int i;
            for(i = 1; i <= N; i++) {

                aux = int.Parse(Console.ReadLine());
                 if( 10 <= aux && aux <= 20) {
                    dentro++;
                }
                 else {
                    fora++;
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");

        }
    }
}
