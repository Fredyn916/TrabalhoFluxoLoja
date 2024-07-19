using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFluxoLoja
{
    public class ProdutoFisico : Produto
    {
        private double Peso { get; set; }

        public ProdutoFisico(int id, string marca, string nome, double preco, int quantidadeEstoque, double peso, int tamanho, string formaPagamento)
            : base(id, marca, nome, preco, quantidadeEstoque, tamanho, formaPagamento)
        {
            Peso = peso;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Peso: {Peso}");
            Console.WriteLine($"----------------------------------");
        }
    }
}
