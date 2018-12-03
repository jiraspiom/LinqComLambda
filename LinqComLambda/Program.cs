using System;
using System.Collections.Generic;
using LinqComLambda.Entidade;

namespace LinqComLambda
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Categoria c1 = new Categoria() { Id = 1, Nome = "Ferramentas", Classificacao = 2 };
            Categoria c2 = new Categoria() { Id = 2, Nome = "Computador", Classificacao = 1 };
            Categoria c3 = new Categoria() { Id = 3, Nome = "Eletronicos", Classificacao = 1 };

            List<Produto> produtos = new List<Produto>() {
                new Produto() { Id = 1, Nome = "Computador", Valor = 1100.0, Categoria = c2 },
                new Produto() { Id = 2, Nome = "Martelo", Valor = 90.0, Categoria = c1 },
                new Produto() { Id = 3, Nome = "TV", Valor = 1700.0, Categoria = c3 },
                new Produto() { Id = 4, Nome = "Notebook", Valor = 1300.0, Categoria = c2 },
                new Produto() { Id = 5, Nome = "Churraqueira", Valor = 80.0, Categoria= c1 },
                new Produto() { Id = 6, Nome = "Tablet", Valor = 700.0, Categoria = c2 },
                new Produto() { Id = 7, Nome = "Camera", Valor = 700.0, Categoria = c3 },
                new Produto() { Id = 8, Nome = "Impressora", Valor = 350.0, Categoria = c3 },
                new Produto() { Id = 9, Nome = "MacBook", Valor = 1800.0, Categoria = c2 },
                new Produto() { Id = 10, Nome = "ApSom", Valor = 700.0, Categoria = c3 },
                new Produto() { Id = 11, Nome = "Nivel", Valor = 70.0, Categoria = c1 }

            };


        }
    }
}
