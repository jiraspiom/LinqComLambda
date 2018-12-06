using System;
using System.Collections.Generic;
using LinqComLambda.Entidade;
using System.Linq;

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
                new Produto() { Id = 11, Nome = "Nivel", Valor = 70.0, Categoria = c1 },
                new Produto() { Id = 12, Nome = "Nivel", Valor = 70.0, Categoria = c1 }

            };

            var resultado1 = produtos.Where(p => p.Categoria.Classificacao == 1 && p.Valor < 900);
            Visualizar("Classificao 1 valor < 900", resultado1);

            var resultado2 = produtos.Where(p => p.Categoria.Nome == "Ferramentas").Select(p => p.Nome);
            Visualizar("Por nomes todas as ferramentas", resultado2);

            var resultado3 = produtos.Where(p => p.Nome[0] == 'C').Select(p => new { p.Nome, p.Valor, nomeCategoria = p.Categoria.Nome });
            Visualizar("produto comeca com c", resultado3);

            var resultado4 = produtos.Where(p => p.Categoria.Classificacao == 1).OrderBy(p => p.Valor).ThenBy(p => p.Nome);
            Visualizar("catetorica 1 ordenado por valor e nome", resultado4);

            var resultado5 = resultado4.Skip(2).Take(4);
            Visualizar("pula os 2 primeiro e pega os 4 proximo", resultado5);


            var resultado6 = produtos.First(); //first gera exessao caso resultqado seje vazio
            Console.WriteLine("Visualizar o primeiro " + resultado6);

            var resultado7 = produtos.Where(p => p.Valor > 3000).FirstOrDefault();
            Console.WriteLine("visualizar primeiro em consulta nula " + resultado7);

            var resultado8 = produtos.Where(p => p.Id == 3).Single(); //single so quando tem certesa que retorna 1 elemento
            Console.WriteLine("primeiro elemento " + resultado8);

            var resultado9 = produtos.Where(p => p.Id > 33).SingleOrDefault(); //single so quando tem certesa que retorna 1 elemento
            Console.WriteLine("primeiro elemento defalt em consulta nula " + resultado9);

            var resultado10 = produtos.Max(p => p.Valor);
            Console.WriteLine("maior valor do produto: " + resultado10);

            var resultado11 = produtos.Min(p => p.Valor);
            Console.WriteLine("menor valor do produto: " + resultado11);

            var resultado12 = produtos.Where(p => p.Categoria.Id == 1).Sum(p => p.Valor);
            Console.WriteLine("A soma dos produtos categ 1 :" + resultado12);

            var resultado13 = produtos.Where(p => p.Categoria.Id == 1).Average(p => p.Valor);
            Console.WriteLine("A media dos produtos categ 1 :" + resultado13);

            var resultado14 = produtos.Where(p => p.Categoria.Id == 5).Select(p => p.Valor).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Media resultado vaziu: " + resultado14);

            var resultado15 = produtos.Where(p => p.Categoria.Id == 1).Select(p => p.Valor).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("resultado soma personalizado: " + resultado15);

            Console.WriteLine("");

            var resultado16 = produtos.GroupBy(p => p.Categoria);
            foreach(IGrouping<Categoria,Produto> group in resultado16)
            {
                Console.WriteLine("Categoria " + group.Key.Nome);
                foreach (Produto p  in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine("");
            }

        }

        static void Visualizar<T>(string mensagem, IEnumerable<T> colecao)
        {

            Console.WriteLine(mensagem);

            foreach (T objeto in colecao)
            {
                Console.WriteLine(objeto);
            }

            Console.WriteLine("");

        }


    }
}
