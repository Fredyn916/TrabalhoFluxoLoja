using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class Sistema
    {
        public void InicializarSistema()
        {
            int opcao = -1;
            OpcoesDoUsuario();

            if (opcao == 1)
            {
                Consultar();
            }
            else if (opcao == 2)
            {

            }
            else if (opcao == 3)
            {

            }
            else if (opcao == 4)
            {

            }
            else if (opcao == 5)
            {

            }

        }

        private int MenuInical()
        {
            int acao = -1;
            Console.WriteLine("<------- BEM VINDO À LOJA ------->");
            Console.WriteLine("1 - Compra de um Produto Físico");
            Console.WriteLine("2 - Compra de um Produto Digital");
            Console.WriteLine("0 - Sair do Sistema");
            Console.WriteLine("<-------------------------------->");
            while (acao != 1 && acao != 2 && acao != 0)
            {
                Console.WriteLine("Digite o número respectivo à ação que deseja realizar:");
                acao = int.Parse(Console.ReadLine());
                if(acao != 1 && acao != 2 && acao != 0)
                {
                    Console.WriteLine("Digite uma opção válida.");
                }
            }
            return acao;
        }

        public void Consultar()
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

