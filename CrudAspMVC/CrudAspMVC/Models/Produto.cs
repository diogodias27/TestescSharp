using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CrudAspMVC.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Preco { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime Data { get; set; }

        public List<Produto> TodosProdutos()
        {
            var produtos = new List<Produto>
            {
               new Produto
               {
                   ProdutoId = 110,
                   Categoria ="antibiotico",
                   Nome = "amoxicilina",
                   Descricao = "indicado para vias aéreas",
                   Preco = 22.90m,
                   Data = new DateTime(2012,5,25)
               },
               new Produto
               {
                   ProdutoId = 120,
                   Categoria = "antibiotico",
                   Nome = "cefalexina",
                   Descricao = "indicado feridas cutaneas",
                   Preco  = 18.90m,
                   Data = new DateTime (2013,6,20)
               },
               new Produto
               {
                ProdutoId = 130,
                Categoria = "antiflamtorio",
                Nome = "diclofenaco",
                Descricao = "indicado para inflamações em geral",
                Preco = 6.90m,
                Data = new DateTime (2014,5,15)


               },

            };
            return produtos;
        }
    }
}