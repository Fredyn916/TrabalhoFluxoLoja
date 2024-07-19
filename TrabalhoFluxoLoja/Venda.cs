using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFluxoLoja
{
    public class Venda
    {
        private int Id { get; set; }
        private List<Produto> ProdutosComprados { get; set; }
        private Usuario Usuario { get; set; }
        private DateTime DataVenda { get; set; }
        private double ValorTotal { get; set; }
        private string Estado { get; set; }
        private string FormgaDePagamento {  get; set; }

        public Venda(int id, List<Produto> carrinho, Usuario usuario, double valorTotal, string estado, string formgaDePagamento)
        {
            Id = id;
            foreach (Produto produtoAdicionado in carrinho)
            {
                ProdutosComprados.Add(produtoAdicionado);
            }
            Usuario = usuario;
            DataVenda = DateTime.Now;
            ValorTotal = valorTotal;
            Estado = estado;
            FormgaDePagamento = formgaDePagamento;
        }

        public void AlterarIdVenda(int id)
        {
            Id = id;
        }

        public void NovoIdVenda(Usuario x)
        {
            int novoID = Usuario.Compras.Max(x => x.Id) + 1;
            AlterarIdVenda(novoID);
        }

        public void DetalhesDaVenda()
        {

        }
    }
}