using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//resolver problemas existente em banco de dados, quase imperceptivel --> tipos primitivos
namespace _04_NullLable
{
    class Program
    {
        static void Main(string[] args)
        {

            //Uma struct - Passa informação passada por valor 
            int i = null;

            // CLasse - Por Referencia
            object o = null;


            /*MSQL - ORacle .... NoSQL - Informações Opcionais que pode ser nula
            Esses dois códigos fazem a mesma coisa,*
            faz com que a variavel possa receber valores nulos ou ser nulo*
            */

            Nullable<int> idade = null;
            int? idade2 = null;  
        }
    }
}
