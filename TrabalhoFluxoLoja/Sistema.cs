using System;
using System.Collections.Generic;
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
                Console.WriteLine("Guilherme é gay");
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

        private void Consultar()
        {
            int idConsulta = -1;
            Console.WriteLine("Digite o numero do estado respectivo que deseja consultar");
            Console.WriteLine("1 - Acre");
            Console.WriteLine("2 - Alagoas");
            Console.WriteLine("3 - Amapa");
            Console.WriteLine("4 - Amazonas");
            Console.WriteLine("5 - Bahia");
            Console.WriteLine("6 - Ceará");
            Console.WriteLine("7 - Distrito Federal");
            Console.WriteLine("8 - Espírito Santo");
            Console.WriteLine("9 - Goiás");
            Console.WriteLine("10 - Mato Grosso");
            Console.WriteLine("11 - Mato Grosso do Sul");
            Console.WriteLine("12 - Minas Gerais");
            Console.WriteLine("13 - Pará");
            Console.WriteLine("14 - Paraíba");
            Console.WriteLine("15 - paraná");
            Console.WriteLine("16 - Pernambuco");
            Console.WriteLine("17 - Piaui");
            Console.WriteLine("18 - Rio de Janeiro");
            Console.WriteLine("19 - Rio Grande do Norte");
            Console.WriteLine("20 - Rio Grande do Sul");
            Console.WriteLine("21 - Rondônia");
            Console.WriteLine("22 - Roraima");
            Console.WriteLine("23 - Santa Catarina");
            Console.WriteLine("24 - São Paulo ");
            Console.WriteLine("25 - Sergipe");
            Console.WriteLine("26 - Tocantis");
            Console.WriteLine("27 - Maranhão");

            idConsulta = int.Parse(Console.ReadLine());

            double valorFrete = GerenciadorFretes.ConsultarFretePorId(idConsulta);

            if (valorFrete != -1)
            {
                Console.WriteLine($"O frete para o estado é de R${valorFrete}");
            }
            else
            {
                Console.WriteLine($"Não foi encontrado frete para o estado com ID {idConsulta}");
            }

        }

        private void OpcoesDoUsuario()
        {
            Console.WriteLine("Digite o numero da opção desejada");
            Console.WriteLine("1 - Consulta de Frete");

        }
    }
}

