using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFluxoLoja;

namespace Trabalho
{
    public class Sistema
    {
        private Usuario Usuario {  get; set; }
        public Gerenciador Gerenciador { get; set; }
        public Sistema()
        {
            Gerenciador = new Gerenciador();
        }

        public void InicializarSistema()
        {
            List<Produto> carrinho = new List<Produto>();
            int opcao1 = -1;
            string estado = string.Empty;
            double valorTotal = 0.0;
            string formaDePagamento = string.Empty;

            while (opcao1 != 0)
            {
                Usuario = LoginOuCadastro();
                // Tipo de venda
                opcao1 = MenuInical();
                Console.Clear();
                // Funcionalidades
                if (opcao1 == 1)
                {
                    carrinho = Gerenciador.ProdutosEscolhidosFisicos();
                }
                else if (opcao1 == 2)
                {
                    carrinho = Gerenciador.ProdutosEscolhidosDigitais();
                }

                Console.WriteLine("<----------------------------->");
                estado = ConsultarRetornarFrete();
                Console.WriteLine("<----------------------------->");
                double frete = GerenciadorFretes.RetornarFretePorEstado(estado);
                valorTotal = Gerenciador.RetornaValorDosProdutosMaisFrete(carrinho, frete);
                Console.WriteLine($"Valor Total da Compra + Frete: R${valorTotal}");
                formaDePagamento = MenuPagamento();

                Gerenciador.RealizarVenda(0, carrinho, Usuario, valorTotal, estado, formaDePagamento);

                opcao1 = MenuFuncionalidades();
                if (opcao1 == 1)
                {
                    ConsultarFrete();
                }
                else if (opcao1 == 2)
                {
                    HistoricoDeCompras.HistoricoDeComprasRealizadas(Usuario);
                }
            }
        }

        public Usuario LoginOuCadastro()
        {
            int acao = -1;
            Console.WriteLine("<-------------------------------->");
            while (acao != 1 && acao != 2)
            {
                Console.WriteLine("1 - Logar");
                Console.WriteLine("2 - Cadastrar");
                Console.WriteLine("<-------------------------------->");
                acao = int.Parse(Console.ReadLine());

                if (acao != 1 && acao != 2)
                {
                    Console.WriteLine("Digite uma opção válida");
                }
            }
            if (acao == 1)
            {
                return Login();
            }
            else if (acao == 2)
            {
                Gerenciador.AdicionarUsuario();
                return Login();
            }
            else
            {
                Console.WriteLine("Guilherme gay");
                return null;
            }
            return null;
        }

        private int MenuInical()
        {
            int acao = -1;
            Console.WriteLine("<------- BEM VINDO À LOJA ------->");
            Console.WriteLine("1 - Compra de um Produto Físico");
            Console.WriteLine("2 - Compra de um Produto Digital");
            Console.WriteLine("0 - Sair do Sistema");
            Console.WriteLine("<-------------------------------->");

            acao = int.Parse(Console.ReadLine());
            while (acao != 1 && acao != 2 && acao != 0)
            {

                acao = int.Parse(Console.ReadLine());
                if (acao != 1 && acao != 2 && acao != 0)
                {
                    Console.WriteLine("Digite uma opção válida.");
                }
            }
            return acao;
        }

        private int MenuFuncionalidades()
        {
            int acao = -1;
            Console.WriteLine("<------- FUNCIONALIDADES ------->");
            Console.WriteLine("1 - Consultar Frete");
            Console.WriteLine("2 - Histórico de Compras");
            Console.WriteLine("0 - Sair do Sistema");
            Console.WriteLine("<------------------------------->");

            acao = int.Parse(Console.ReadLine());
            while (acao != 1 && acao != 2 && acao != 0)
            {

                acao = int.Parse(Console.ReadLine());
                if (acao != 1 && acao != 2 && acao != 0)
                {
                    Console.WriteLine("Digite uma opção válida.");
                }
            }
            return acao;
        }

        private string MenuPagamento()
        {
            string formaDePagamento = string.Empty;
            int acao = -1;
            Console.WriteLine("<------- FORMA DE PAGAMENTO ------->");
            Console.WriteLine("1 - Boleto");
            Console.WriteLine("2 - Pix");
            Console.WriteLine("3 - Cartão de Crédito");
            Console.WriteLine("<-------------------------------->");

            acao = int.Parse(Console.ReadLine());
            while (acao != 1 && acao != 2 && acao != 3)
            {

                acao = int.Parse(Console.ReadLine());
                if (acao != 1 && acao != 2 && acao != 3)
                {
                    Console.WriteLine("Digite uma opção válida.");
                }
            }
            if(acao == 1)
            {
                formaDePagamento = "Boleto";
            }
            else if(acao == 2)
            {
                formaDePagamento = "Pix";
            }
            else if (acao == 2)
            {
                formaDePagamento = "Cartão de Crédito";
            }
            return formaDePagamento;
        }

        private Usuario Login()
        {
            Console.WriteLine("<------------ LOGIN ------------>");
            bool verificacaoSenha = false;
            int id = 0;
            string senha = string.Empty;
            while (!verificacaoSenha)
            {
                Console.WriteLine("Digite o número id da conta:");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a senha do login da conta:");
                senha = Console.ReadLine();
                if (Gerenciador.LoginSenha(senha, id))
                {
                    Console.Clear();
                    Console.WriteLine("Login efetuado com sucesso.");
                    verificacaoSenha = true;
                }
                else
                {
                    Console.WriteLine("Id ou Senha incorreto(s).");
                }
            }
            Console.WriteLine("<------------------------------->");
            return Gerenciador.BuscarUsuario(senha, id);
        }

        public string ConsultarRetornarFrete()
        {
            string EstadoFinal = string.Empty;
            int idConsulta = -1;
            while (idConsulta < 0 || idConsulta > 27)
            {
                GerenciadorFretes.Estados();
                Console.WriteLine("Digite o número do estado respectivo que deseja consultar (digite 0 para sair)");
                idConsulta = int.Parse(Console.ReadLine());

                if (idConsulta < 1 || idConsulta > 27)
                {
                    Console.Clear();
                    Console.WriteLine("Por favor, digite um número válido.");
                }

                if (idConsulta == 0)
                {
                    break;
                }

                EstadoFinal = EstadosVenda(idConsulta);
                double valorFrete = GerenciadorFretes.RetornarFretePorEstado(EstadoFinal);

                if (valorFrete != -1)
                {
                    Console.Clear();
                    Console.WriteLine($"O frete para o estado é de R${valorFrete}");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Estado não encontrado. Por favor, digite um número válido de estado.");
                }
            }
            return EstadoFinal;
        }

        public void ConsultarFrete()
        {
            GerenciadorFretes.Estados();
            Console.WriteLine("digite o estado que deseja consultar ");
            int Frete = int.Parse(Console.ReadLine());
            double valorFrete = GerenciadorFretes.ConsultarFretePorId(Frete);
            Console.WriteLine($"O frete para o estado é de R${valorFrete}");
        }

        private string EstadosVenda(int id)
        {
            string Estado = string.Empty;
            switch (id)
            {
                case 1:
                    Estado = "Acre";
                    break;
                case 2:
                    Estado = "Alagoas";
                    break;
                case 3:
                    Estado = "Amapá";
                    break;
                case 4:
                    Estado = "Amazonas";
                    break;
                case 5:
                    Estado = "Bahia";
                    break;
                case 6:
                    Estado = "Ceará";
                    break;
                case 7:
                    Estado = "Distrito Federal";
                    break;
                case 8:
                    Estado = "Espírito Santo";
                    break;
                case 9:
                    Estado = "Goiás";
                    break;
                case 10:
                    Estado = "Mato Grosso";
                    break;
                case 11:
                    Estado = "Mato Grosso do Sul";
                    break;
                case 12:
                    Estado = "Minas Gerais";
                    break;
                case 13:
                    Estado = "Pará";
                    break;
                case 14:
                    Estado = "Paraíba";
                    break;
                case 15:
                    Estado = "Paraná";
                    break;
                case 16:
                    Estado = "Pernambuco";
                    break;
                case 17:
                    Estado = "Piauí";
                    break;
                case 18:
                    Estado = "Rio de Janeiro";
                    break;
                case 19:
                    Estado = "Rio Grande do Norte";
                    break;
                case 20:
                    Estado = "Rio Grande do Sul";
                    break;
                case 21:
                    Estado = "Rondônia";
                    break;
                case 22:
                    Estado = "Roraima";
                    break;
                case 23:
                    Estado = "Santa Catarina";
                    break;
                case 24:
                    Estado = "São Paulo";
                    break;
                case 25:
                    Estado = "Sergipe";
                    break;
                case 26:
                    Estado = "Tocantis";
                    break;
                case 27:
                    Estado = "Maranhão";
                    break;
            }
            return Estado;
        }
    }
}