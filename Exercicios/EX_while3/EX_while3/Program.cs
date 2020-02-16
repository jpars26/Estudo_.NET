using System;

namespace EX_while3 {
    class Program {
        static void Main(string[] args) {

            //Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
           // um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
           // 4.Fim).Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
         // que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
         // mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.
                      Console.WriteLine("Digite o numero do combustivel abastecido!!");

            int numero = int.Parse(Console.ReadLine());
            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;

            while(numero != 4) {

                if(numero == 1) {

                    alcool++;
                    Console.WriteLine("Digite outro numero: ");
                    numero = int.Parse(Console.ReadLine());

                } else if( numero == 2) {

                    gasolina++;
                    Console.WriteLine("Digite outro numero: ");
                    numero = int.Parse(Console.ReadLine());


                } else if( numero == 3) {

                    diesel++;
                    Console.WriteLine("Digite outro numero: ");
                    numero = int.Parse(Console.ReadLine());

                } else {
                    Console.WriteLine("Digite outro numero: ");
                    numero = int.Parse(Console.ReadLine());

                }

               
            }
            Console.WriteLine("Muito Obrigado: ");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}
