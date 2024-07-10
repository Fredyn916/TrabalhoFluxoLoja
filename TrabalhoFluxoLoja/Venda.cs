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

        public Venda()
        {
            DataVenda = DateTime.Now;
        }

        public void AlterarIdVenda(int id)
        {
            Id = id;
        }
    }
}