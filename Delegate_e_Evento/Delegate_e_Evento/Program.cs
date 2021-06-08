using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_e_Evento
{
    class Program
    {

        delegate int Calcula(int a, int b);
        static void Main(string[] args)
        {

            /*Forma convencional
            var so = Soma(10, 20);
            var su = Subitrair(30, 10);
            */

            //UTILIZANDO DELEGATE
            Calcula calc = new Calcula(Soma);
            int so = calc(10, 20);

            Calcula calc1 = new Calcula(Subitrair);
            int su = calc1(20, 10);


            Console.WriteLine($"Soma: {so} ----- Subtração: {su}");
            Console.ReadKey();

        }

        static int Soma(int a, int b)
        {
            return a + b;
        }

        static int Subitrair(int a, int b)
        {
            return a - b;
        }
    }
}
