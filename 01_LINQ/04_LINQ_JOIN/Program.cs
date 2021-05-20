using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LINQ_JOIN
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Autor> listaAutor = new List<Autor>();
            listaAutor.Add( new Autor() { id = 1, Nome = "Joao Paulo" });
            listaAutor.Add(new Autor() { id = 2, Nome = "José" });
            listaAutor.Add(new Autor() { id = 3, Nome = "Maria" });

            List<Livro> listaLivro = new List<Livro>();

            listaLivro.Add( new Livro() { id = 1, AutorID = 1, Titulo = "As Trança do rei careca" });
            listaLivro.Add(new Livro() { id = 2, AutorID = 2, Titulo = "Fogo em alto mar" });
            listaLivro.Add(new Livro() { id = 3, AutorID = 2, Titulo = "Moto com ré" });
            listaLivro.Add(new Livro() { id = 4, AutorID = 3, Titulo = "Agulha no palheiro" });

            var ListaJoin = from livros in listaLivro join autor in listaAutor on livros.AutorID equals autor.id select new { livros, autor};

            foreach(var item in ListaJoin)
            {
                Console.WriteLine($"Livro: {item.livros.Titulo} - Autor: {item.autor.Nome}");
            }
            Console.ReadKey();
        }
    }
}
