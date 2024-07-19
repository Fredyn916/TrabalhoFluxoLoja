using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFluxoLoja
{
    public class Usuario
    {
        public int Id { get; set; }
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private string Endereco { get; set; }
        public List<Produto> Compras { get; set; }

        public Usuario(int id, string nome, string email, string senha, string endereco)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Password = senha;
            Endereco = endereco;
        }

        public bool VerficarSenhaId(string senha, int id)
        {
            if (id == Id)
            {
                if (senha == Password) return true;
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void AlterarIdUsuario(int id)
        {
            Id = id;
        }

        public void AdicionarUsuario(string nome, string email, string endereco)
        {
            Nome = nome;
            Email = email;
            Endereco = endereco;
        }
    }
}