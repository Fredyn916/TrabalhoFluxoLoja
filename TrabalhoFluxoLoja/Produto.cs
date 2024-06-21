using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFluxoLoja
{
    public abstract class Produto
    {
        public int Id { get; set; }
        private string Marca { get; set; }
        private string Nome { get; set; }
        private double Preco { get; set; }
        private int QuantidadeEstoque { get; set; }
        private int Tamanho { get; set; }
        private string FormaPagamento { get; set; }

        public Produto(int id, string marca,string nome, double preco, int quantidadeEstoque, int tamanho, string formaPagamento)
        {
            Id = id;
            Marca = marca;
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
            Tamanho = tamanho;
            FormaPagamento = formaPagamento;
        }
    }
}