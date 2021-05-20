using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            // LINQ E LAMBDA
            //LAMBDA = (ENTRADA) => (EXORESSAO)
            int[] lista = { 3, 5, 7, 8, 20, 12, 18, 9, 90 };

            var listafiltrada = lista.Where(ENTRADA => ENTRADA > 10).OrderBy(ENTRADA => ENTRADA).Select(ENTRADA => ENTRADA);
            foreach (var item in listafiltrada)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            
        }
    }
}
