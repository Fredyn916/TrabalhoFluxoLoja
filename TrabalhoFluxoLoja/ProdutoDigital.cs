using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFluxoLoja
{
    public class ProdutoDigital : Produto
    {
        private string Plataforma { get; set; }

        public ProdutoDigital(int id, string marca, string nome, double preco, int quantidadeEstoque, string plataforma, int tamanho, string formaPagamento)
            : base(id, marca, nome, preco, quantidadeEstoque, tamanho, formaPagamento)
        {
            Plataforma = plataforma;
        }

        public void ExibirDetalhes()
        {

        }
    }
}