using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuplas.Models
{
    public class Venda
    {

        public int Id { get; set; }
        public string? Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; }

        public Venda(int id, string produto, decimal preco, DateTime dataAtual, decimal? desconto)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataAtual;
            Desconto = desconto;
        }
    }
}