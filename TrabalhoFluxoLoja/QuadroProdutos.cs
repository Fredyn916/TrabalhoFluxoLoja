using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFluxoLoja
{
    public class QuadroProdutos
    {
        public List<Usuario> UsuariosCadastrados { get; set; }
        public List<Produto> ProdutosEstoqueFisico { get; set; }
        public List<Produto> ProdutosEstoqueDigital { get; set; }

        public QuadroProdutos()
        {
            UsuariosCadastrados = new List<Usuario>();
            ProdutosEstoqueFisico = new List<Produto>();
            ProdutosEstoqueDigital = new List<Produto>();
            CadastroUsuarioLoja();
            EstoqueProdutos();
        }

        private void CadastroUsuarioLoja()
        {
            UsuariosCadastrados.Add(new Usuario(10000, "Funcionário Loja", "funcionarios@loja.com", "loja123#","Centro Sabará - MG 34505-730"));
        }

        private void EstoqueProdutos()
        {
            ProdutosEstoqueFisico.Add(new ProdutoFisico(1, "Nike", "Air Force 1 Low Triple White", 397.00, 10, 0.475, 0, "Forma de Pagamento"));
            ProdutosEstoqueFisico.Add(new ProdutoFisico(2, "Nike", "Air Max 97 Triple White", 427.00, 10, 2.1, 0, "Forma de Pagamento"));
            ProdutosEstoqueFisico.Add(new ProdutoFisico(3, "Nike x Corteiz", "Air Max 95 Gutta Green", 397.00, 10, 2.1, 0, "Forma de Pagamento"));
            ProdutosEstoqueFisico.Add(new ProdutoFisico(4, "Nike", "Air Jordan 4 Black Cat", 447.90, 10, 0.76, 0, "Forma de Pagamento"));
            ProdutosEstoqueFisico.Add(new ProdutoFisico(5, "Nike", "Air Max Plus Drift Yin Yang", 427.90, 10, 0.31, 0, "Forma de Pagamento"));
            ProdutosEstoqueFisico.Add(new ProdutoFisico(6, "Adidas x Bape", "Forum Low 30th Anniversary Green", 627.00, 10, 0.328, 0, "Forma de Pagamento"));
            ProdutosEstoqueFisico.Add(new ProdutoFisico(7, "Adidas", "Forum Low Wild Teal", 587.90, 10, 0.42, 0, "Forma de Pagamento"));
            ProdutosEstoqueFisico.Add(new ProdutoFisico(8, "Adidas", "Yeezy Boost 350 V2 Static Reflective", 597.90, 10, 2.1, 0, "Forma de Pagamento"));
            ProdutosEstoqueFisico.Add(new ProdutoFisico(9, "Adidas", "Yeezy 700 V3 Alvah", 547.90, 10, 1.9, 0, "Forma de Pagamento"));
            ProdutosEstoqueFisico.Add(new ProdutoFisico(10, "Adidas", "Adds 2000", 799.00, 10, 1.75, 0, "Forma de Pagamento"));

            ProdutosEstoqueDigital.Add(new ProdutoDigital(1, "Nike", "Air Force 1 Low Triple White", 397.00, 10, "Plataforma", 0, "Forma de Pagamento"));
            ProdutosEstoqueDigital.Add(new ProdutoDigital(2, "Nike", "Air Max 97 Triple White", 427.00, 10, "Plataforma", 0, "Forma de Pagamento"));
            ProdutosEstoqueDigital.Add(new ProdutoDigital(3, "Nike x Corteiz", "Air Max 95 Gutta Green", 397.00, 10, "Plataforma", 0, "Forma de Pagamento"));
            ProdutosEstoqueDigital.Add(new ProdutoDigital(4, "Nike", "Air Jordan 4 Black Cat", 447.90, 10, "Plataforma", 0, "Forma de Pagamento"));
            ProdutosEstoqueDigital.Add(new ProdutoDigital(5, "Nike", "Air Max Plus Drift Yin Yang", 427.90, 10, "Plataforma", 0, "Forma de Pagamento"));
            ProdutosEstoqueDigital.Add(new ProdutoDigital(6, "Adidas x Bape", "Forum Low 30th Anniversary Green", 627.00, 10, "Plataforma", 0, "Forma de Pagamento"));
            ProdutosEstoqueDigital.Add(new ProdutoDigital(7, "Adidas", "Forum Low Wild Teal", 587.90, 10, "Plataforma", 0, "Forma de Pagamento"));
            ProdutosEstoqueDigital.Add(new ProdutoDigital(8, "Adidas", "Yeezy Boost 350 V2 Static Reflective", 597.90, 10, "Plataforma", 0, "Forma de Pagamento"));
            ProdutosEstoqueDigital.Add(new ProdutoDigital(9, "Adidas", "Yeezy 700 V3 Alvah", 547.90, 10, "Plataforma", 0, "Forma de Pagamento"));
            ProdutosEstoqueDigital.Add(new ProdutoDigital(10, "Adidas", "Adds 2000", 799.00, 10, "Plataforma", 0, "Forma de Pagamento"));
        }

        public void AdicionarUsuario(Usuario x)
        {
            int novoID = UsuariosCadastrados.Max(x => x.Id) + 1;
            x.AlterarIdUsuario(novoID);
            UsuariosCadastrados.Add(x);
        }

        public Produto BuscarProdutoFisicoPorId(int id)
        {
            foreach (Produto produto in ProdutosEstoqueFisico)
            {
                if (produto.Id == id)
                {
                    return produto;
                }
            }
            return null;
        }

        public Produto BuscarProdutoDigitalPorId(int id)
        {
            foreach (Produto produto in ProdutosEstoqueDigital)
            {
                if (produto.Id == id)
                {
                    return produto;
                }
            }
            return null;
        }

        public void ListarProdutoFisico()
        {
            Console.WriteLine("<---------- PRODUTOS FÍSICOS ---------->");
            foreach (ProdutoFisico x in ProdutosEstoqueFisico)
            {
                x.ExibirDetalhes();
            }
            Console.WriteLine("<-------------------------------------->");
        }

        public void ListarProdutoDigital()
        {
            Console.WriteLine("<---------- PRODUTOS DIGITAIS ---------->");
            foreach (ProdutoDigital x in ProdutosEstoqueDigital)
            {
                x.ExibirDetalhes();
            }
            Console.WriteLine("<--------------------------------------->");
        }
    }
}