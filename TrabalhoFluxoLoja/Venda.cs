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
        private string FormaDePagamento {  get; set; }

        public Venda(int id, List<Produto> carrinho, Usuario usuario, double valorTotal, string estado, string formgaDePagamento)
        {
            ProdutosComprados = new List<Produto>();

            Id = id;
            foreach (Produto produtoAdicionado in carrinho)
            {
                ProdutosComprados.Add(produtoAdicionado);
            }
            Usuario = usuario;
            DataVenda = DateTime.Now;
            ValorTotal = valorTotal;
            Estado = estado;
            FormaDePagamento = formgaDePagamento;
        }

        public void AlterarIdVenda(int id)
        {
            Id = id;
        }

        public void NovoIdVenda(Usuario x)
        {
            int novoID = Usuario.Compras.Count > 0 ? Usuario.Compras.Max(x => x.Id) + 1 : 1;
            AlterarIdVenda(novoID);
        }

        public virtual void DetalhesDaVenda()
        {
            Console.Clear();
            Console.WriteLine($"<-------- Detalhes da Compra --------->");
            Console.WriteLine($"//------- PRODUTO(S) COMPRADO(S) --------//");
            foreach (Produto produto in ProdutosComprados)
            {
                produto.ExibirDetalhes();
                Console.WriteLine($"----------------------------------");
            }
            Console.WriteLine($"//-----------------------------------//");
            Console.WriteLine($"Usuário: {Usuario.Nome}");
            Console.WriteLine($"Data da Venda: {DataVenda}");
            Console.WriteLine($"Valor Total da Venda: R${ValorTotal}");
            Console.WriteLine($"Estado: {Estado}");
            Console.WriteLine($"Forma de Pagamento: {FormaDePagamento}");
            Console.WriteLine($"<----------------------------------------->");
        }
    }
}