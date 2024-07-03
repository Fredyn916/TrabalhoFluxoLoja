using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFluxoLoja
{
    public static class CriarUsuario
    {
        public static Usuario CriarUmUsuario()
        {
            Console.WriteLine("<--------- CADASTRO USUÁRIO --------->");
            Console.WriteLine("Digite o nome do usuário:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o email do usuário:");
            string email = Console.ReadLine();
            Console.WriteLine("Digite a senha do usuário:");
            string senha = Console.ReadLine();
            Console.WriteLine("Digite o endereço do usuário:");
            string endereco = Console.ReadLine();
            Usuario x = new Usuario(0, nome, email, senha, endereco);
            Console.WriteLine("<------------------------------------>");

            return x;
        }
    }
}
