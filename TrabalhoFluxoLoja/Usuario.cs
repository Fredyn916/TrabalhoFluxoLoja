using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFluxoLoja
{
    public class Usuario
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Endereco { get; set; }

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