# Estudo_.NET

##Exercicios de fixação do conteudo

    Ex 1 :   Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
    mensagem explicativa, conforme exemplos.
    
    using System;
    using System.Globalization;

    namespace Primeiro {
           class Program {
              static void Main(string[] args) {

                Console.WriteLine("Ler dois valores inteiros, e depois mostrar na tela a soma desses números: "); 

                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int soma = num1 + num2;

                Console.WriteLine("O resultado foi: " + soma);

           }
       }
    }
