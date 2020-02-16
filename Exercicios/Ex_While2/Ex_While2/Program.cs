using System;

namespace Ex_While2 {
    class Program {
        static void Main(string[] args) {

            // Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
            // cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            //menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).
            Console.WriteLine("Entre com as coordenadas!!");

            string[] coord = Console.ReadLine().Split(' ');

            int X = int.Parse(coord[0]);
            int Y = int.Parse(coord[1]);

            while( X != 0 && Y != 0) {

                if (X > 0 && Y > 0) {

                    Console.WriteLine("Primeiro");
                } else if (X < 0 && Y > 0) {

                    Console.WriteLine("Segundo");
                } else if (X < 0 && Y < 0) {

                    Console.WriteLine("Terceiro");

                }else {

                Console.WriteLine("Quarto");
            }
                Console.WriteLine("Entre com as coordenadas novamente!!");
                coord = Console.ReadLine().Split(' ');

                 X = int.Parse(coord[0]);
                 Y = int.Parse(coord[1]);
            }


        }

       
    }
}
