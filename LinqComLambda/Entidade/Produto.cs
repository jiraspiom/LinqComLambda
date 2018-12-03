using System;
using System.Globalization;
namespace LinqComLambda.Entidade
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Categoria Categoria { get; set; }

        public override string ToString()
        {
            return Id + ", "
                + Nome + ", "
                + Valor.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + Categoria.Nome + ", "
                + Categoria.Classificacao;
        }
    }
}
