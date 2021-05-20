using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _01_Generics.Modelo;

namespace _01_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Casa casa = new Casa() { Cidade = "Pouso Alegre", Endereço = "Luiz Barbato" };
            Carro carro = new Carro() { Marca = "FIAT", Modelo = "TEMPRA" };
            Usuario usuario = new Usuario() { Email = "temprao@tunado.com", Nome = "Joao", senha = "123456" };


            Serializador.Serializar(carro);
            Serializador.Serializar(usuario);
            Serializador.Serializar(casa);


            Casa casa2 = Serializador.Deserializar<Casa>();
            Carro carro2 = Serializador.Deserializar<Carro>();
            Usuario usuario2 = Serializador.Deserializar<Usuario>();

            Console.WriteLine($" Carro2: {carro2.Marca}  Modelo: {carro2.Modelo}");
            Console.WriteLine($" Casa2: {casa2.Cidade}   Endereço: {casa2.Endereço}");
            Console.WriteLine($"USuario2: {usuario2.Nome}  Email: {usuario2.Email}");

            Console.ReadKey();
        }
    }
}
