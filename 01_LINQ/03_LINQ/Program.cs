using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Usuario> lista = new List<Usuario>();

            lista.Add(new Usuario() { Nome = "Joao", Email = "joao@gmail.com" });
            lista.Add(new Usuario() { Nome = "Maria", Email = "Maria@gmail.com" });
            lista.Add(new Usuario() { Nome = "Jose", Email = "Jose@hotmail.com" });
            lista.Add(new Usuario() { Nome = "Gabi", Email = "Gabi@gmail.com" });
            lista.Add(new Usuario() { Nome = "Anna", Email = "Anna@gmail.com" });

            var ListaFiltrada = from a in lista where a.Email.Contains("@gmail.com")orderby a.Nome select a ;

            foreach (var item in ListaFiltrada)
            {
                Console.WriteLine($"{item.Nome} - {item.Email}");
            }
            Console.ReadKey();
        }
    }
}
