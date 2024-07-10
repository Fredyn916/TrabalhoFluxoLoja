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

        public Venda(int id, Usuario usuario, double valorTotal, string estado)
        {
            Id = id;
            Usuario = usuario;
            DataVenda = DateTime.Now;
            ValorTotal = valorTotal;
            Estado = estado;
        }

        public void AlterarIdVenda(int id)
        {
            Id = id;
        }
    }
}