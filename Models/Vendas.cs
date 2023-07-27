// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Newtonsoft.Json;

// namespace ExemplosExplorando___Aula2___Parte_2.Models
// {
//     public class Vendas
//     {
//         public Vendas (int id, string produto, decimal preco, DateTime dataVenda)
//         {
//             Produto = produto;
//             Preco = preco;
//             Id = id;
//             DataVenda = dataVenda;
//         }

//         public int Id { get; set; }
//         [JsonProperty("Nome_Produto")]
//         public string Produto { get; set; }
//         public decimal Preco { get; set; }
//         public DateTime DataVenda{ get; set; }
//     }
// }