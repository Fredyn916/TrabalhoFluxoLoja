using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFluxoLoja
{
    public class Gerenciador
    {
        public QuadroProdutos Quadro { get; set; }
        public Gerenciador()
        {
            Quadro = new QuadroProdutos();
        }

        public int CountUsuarios() => Quadro.UsuariosCadastrados.Count();

        public void AdicionarUsuario()
        {
            Usuario x = CriarUsuario.CriarUmUsuario();
            Quadro.AdicionarUsuario(x);
        }

        public bool LoginSenha(string senha, int id)
        {
            if (id < 10000)
            {
                return false;
            }
            foreach (Usuario x in Quadro.UsuariosCadastrados)
            {
                if (x.VerficarSenhaId(senha, id))
                {
                    return true;
                }
            }
            return false;
        }

        public Usuario BuscarUsuario(string senha, int id)
        {
            foreach (Usuario x in Quadro.UsuariosCadastrados)
            {
                if (x.VerficarSenhaId(senha, id))
                {
                    return x;
                }
            }
            return null;
        }

        // VENDA

        //public void AdicionarUsuario(Usuario x) (MÉTODO PARA ALTERAR ID DA LISTA DAS COMPRAS)
        //{
        //    int novoID = UsuariosCadastrados.Max(x => x.Id) + 1;
        //    x.AlterarIdUsuario(novoID);
        //    UsuariosCadastrados.Add(x);
        //}

        public void RealizarVenda(int id, List<Produto> carrinho, Usuario usuario, double valorTotal, string estado)
        {
            int Id = id;
            Venda Venda = new Venda(Id, carrinho, usuario, valorTotal, estado);
        }

        public List<Produto> ProdutosEscolhidosFisicos()
        {
            List<Produto> produtosEscolhidosFisicos = new List<Produto>();
            int acao = -1;
            int id = -1;

            while (acao != 2)
            {
                acao = MenuEscolhaProdutos();
                if (acao == 1)
                {
                    Quadro.ListarProdutoFisico();
                    while (id < 1 || id > 10)
                    {
                        Console.WriteLine($"Digite o Id do produto que deseja selecionar");
                        id = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Produto selecionado com sucesso");

                        if (id < 1 && id > 10)
                        {
                            Console.WriteLine("Digite um Id válido");
                        }
                        foreach (Produto p in Quadro.ProdutosEstoqueFisico)
                        {
                            if (p.Id == id)
                            {
                                p.RetirarProdutoDoEstoque();
                                break;
                            }
                        }
                    }
                    Produto produtoParaAdicionar = Quadro.BuscarProdutoFisicoPorId(id);
                    produtosEscolhidosFisicos.Add(produtoParaAdicionar);
                }
                else if (acao == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Seleção Finalizada");
                }
            }

            return produtosEscolhidosFisicos;
        }

        public List<Produto> ProdutosEscolhidosDigitais()
        {
            List<Produto> produtosEscolhidosDigitais = new List<Produto>();
            int acao = -1;
            int id = -1;

            while (acao != 2)
            {
                acao = MenuEscolhaProdutos();
                if (acao == 1)
                {
                    Quadro.ListarProdutoDigital();
                    while (id < 1 && id > 10)
                    {
                        Console.WriteLine($"Digite o Id do produto que deseja selecionar");
                        id = int.Parse(Console.ReadLine());
                        if (id < 1 && id > 10)
                        {
                            Console.WriteLine("Digite um Id válido");
                        }
                        foreach (Produto p in Quadro.ProdutosEstoqueDigital)
                        {
                            if(p.Id == id)
                            {
                                p.RetirarProdutoDoEstoque();
                                id = -1;
                                break;
                            }
                        }
                    }
                    Produto produtoParaAdicionar = Quadro.BuscarProdutoDigitalPorId(id);
                    produtosEscolhidosDigitais.Add(produtoParaAdicionar);

                }
                else if (acao == 2)
                {
                    Console.WriteLine("Seleção Finalizada");
                }
            }

            return produtosEscolhidosDigitais;
        }

        public double RetornaValorDosProdutosMaisFrete(List<Produto> listaDosProdutos, double valorFrete)
        {
            double valorTotal = 0.0;
            foreach (Produto p in listaDosProdutos)
            {
                valorTotal = valorTotal + p.ValorProduto();
            }
            valorTotal = valorTotal + valorFrete;
            return valorTotal;
        }

        private int MenuEscolhaProdutos()
        {
            int escolha = 0;

            while (escolha != 1 && escolha != 2)
            {
                Console.WriteLine($"<----- ESCOLHA ----->");
                Console.WriteLine($"1 - Escolher produto");
                Console.WriteLine($"2 - Finalizar escolha");
                Console.WriteLine($"<------------------->");
                escolha = int.Parse(Console.ReadLine());
                if (escolha != 1 && escolha != 2)
                {
                    Console.WriteLine("Digite uma opção válida");
                }
            }

            return escolha;
        }
    }
}