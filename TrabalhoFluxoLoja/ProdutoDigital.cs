using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrabalhoFluxoLoja
{
    public class ProdutoDigital : Produto
    {
        private string Plataforma { get; set; }

        public ProdutoDigital(int id, string marca, string nome, double preco, int quantidadeEstoque, int tamanho)
            : base(id, marca, nome, preco, quantidadeEstoque, tamanho)
        {
            Plataforma = "Instagram";
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Plataforma: {Plataforma}");
            Console.WriteLine($"----------------------------------");
        }
    }
}