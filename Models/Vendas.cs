using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemplosExplorando___Aula2___Parte_2.Models
{
    public class Vendas
    {
        public Vendas (int id, string produto, decimal preco, DateTime dataVenda, decimal? desconto)
        {
            Produto = produto;
            Preco = preco;
            Id = id;
            DataVenda = dataVenda;
            Desconto = desconto;
        }

        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda{ get; set; }
        public decimal? Desconto { get; set; }
    }
}