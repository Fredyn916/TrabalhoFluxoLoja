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
        public Gerenciador Gerenciador { get; set; }
        public Sistema()
        {
            Gerenciador = new Gerenciador();
        }

        public void InicializarSistema()
        {
            Usuario usuario;
            int opcao1 = -1;
            
            while(opcao1 != 0)
            {
                opcao1 = MenuInical();

                if(opcao1 == 1)
                {
                    usuario = Login();
                }
                else if(opcao1 == 2)
                {
                    usuario = LoginOuCadastro();
                }
            }
        }

        private Usuario LoginOuCadastro()
        {
            int acao = -1;
            Console.WriteLine("<-------------------------------->");
            while (acao != 1 && acao != 2)
            {
                Console.WriteLine("1 - Logar");
                Console.WriteLine("2 - Cadastrar");
                Console.WriteLine("<-------------------------------->");
                acao = int.Parse(Console.ReadLine());

                if(acao != 1 && acao != 2)
                {
                    Console.WriteLine("Digite uma opção válida");
                }
            }
            if(acao == 1)
            {
                return Login();
            }
            else if(acao == 2)
            {
                Gerenciador.AdicionarUsuario();
                return Login();
            }
            else
            {
                Console.WriteLine("vsfd");
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
                if(acao != 1 && acao != 2 && acao != 0)
                {
                    Console.WriteLine("Digite uma opção válida.");
                }
            }
            return acao;
        }

        private Usuario Login()
        {
            Console.WriteLine("<------------ LOGIN ------------>");
            bool verificacaoSenha = false;
            int id = 0;
            string senha = string.Empty;
            while (!verificacaoSenha)
            {
                Console.WriteLine("Digite o número id:");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a senha do login:");
                senha = Console.ReadLine();
                if (Gerenciador.LoginSenha(senha, id))
                {
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

        public string Consultar()
        {
            string EstadoFinal = String.Empty;
            int idConsulta = -1;

            while (true)
            {
                GerenciadorFretes.Estados();
                Console.WriteLine("Digite o número do estado respectivo que deseja consultar (digite 0 para sair)");
                if (!int.TryParse(Console.ReadLine(), out idConsulta))
                {
                    Console.Clear();
                    Console.WriteLine("Por favor, digite um número válido.");
                    continue;
                }

                if (idConsulta == 0)
                {
                    break;
                }

                double valorFrete = GerenciadorFretes.ConsultarFretePorId(idConsulta);

                if (valorFrete != -1)
                {

                    Console.Clear();
                    Console.WriteLine($"O frete para o estado é de R${valorFrete}");
                    EstadoFinal = EstadosVenda(idConsulta);
                }
                else
                {

                    Console.Clear();
                    Console.WriteLine("Estado não encontrado. Por favor, digite um número válido de estado.");
                }
            }
            return EstadoFinal;
        }

        private void OpcoesDoUsuario()
        {
            Console.WriteLine("Digite o numero da opção desejada");
            Console.WriteLine("1 - Consulta de Frete");

        }

        private string EstadosVenda(int id)
        {
            string Estado = String.Empty;
            switch (id)
            {
                case 1: Estado = "Acre";
                    break;
                case 2:
                    Estado = "Alagoas";
                    break;
                case 3:
                    Estado = "Amapa";
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
                    Estado = "paraná";
                    break;
                case 16:
                    Estado = "Pernambuco";
                    break;
                case 17:
                    Estado = "Piaui";
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