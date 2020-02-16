# Estudo_.NET

<<<<<<< HEAD
# **Exercicios de fixação do conteudo**

- **Exercício 1** :   Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
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

- **Exercício 2:** Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos. Fórmula da área: area = π . raio2. Considere o valor de π = 3.14159.


         Console.WriteLine("ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais:  "); 

            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14159

           double raio = pi * Math.Pow(raio, 2.0);

            Console.WriteLine("O resultado foi: " + raio);


- **Exercício 3:** Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

          Console.WriteLine("a ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: ");

            //"DIFERENCA = (A * B - C * D). :"
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int diferenca = num1 * num2 - num3 * num4;

            Console.WriteLine("DIFERENÇA: " + diferenca);

- **Exercício 4:** Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
decimais.

        Console.WriteLine(" leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário: ");


            int funcionarios = int.Parse( Console.ReadLine());
            double horas = double.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * valor;

            Console.WriteLine("Number = " + funcionarios);
            Console.WriteLine("Salary = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));


- **Exercício 5:** Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

        Console.WriteLine(" Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago: ");
            // 12 1 5.30
            // 16 2 5.10
            Console.WriteLine("Coloque as info da peca 1");
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse( vet[0]);
            int numpeca = int.Parse(vet[1]);
            double valor = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Coloque as info da peca 2");

            string[] vet2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vet2[0]);
            int numpeca2 = int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double resultado = (numpeca * valor) + (numpeca2 * valor2);

            Console.WriteLine("VALOR A PAGAR = " + resultado.ToString("F2", CultureInfo.InvariantCulture));

- **Exercício 6:** Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:

a) a área do triângulo retângulo que tem A por base e C por altura.

b) a área do círculo de raio C. (pi = 3.14159)

c) a área do trapézio que tem A e B por bases e C por altura.

d) a área do quadrado que tem lado B.

e) a área do retângulo que tem lados A e B.

         Console.WriteLine(" leia três valores com ponto flutuante de dupla precisão: A, B e C.: ");
            // 3.0 4.0 5.2
            //a) a área do triângulo retângulo que tem A por base e C por altura.
            //b) a área do círculo de raio C. (pi = 3.14159)
            //c) a área do trapézio que tem A e B por bases e C por altura.
            //d) a área do quadrado que tem lado B.
            //e) a área do retângulo que tem lados A e B.

            Console.WriteLine("Entre com os valores: ");
            string[] valores = Console.ReadLine().Split(' ');
            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double pi = 3.14159;

            double triangulo = A * C / 2.0;
            double raio = pi * Math.Pow(C, 2);
            double trapezio = A * B / 2.0 * C;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine("Os resultados são: ");
            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + raio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));




=======
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
>>>>>>> e8f630bcc83e680507b5caa0f74b843d4e1dd19c
