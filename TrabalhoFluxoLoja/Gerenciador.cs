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
        
        public bool LoginSenha(string senha, int id)
        {
            if (id < 10000)
            {
                return false;
            }
            foreach(Usuario x in Quadro.UsuariosCadastrados)
            {
                if(x.VerficarSenhaId(senha, id))
                {
                    return true;
                }
            }
            return false;
        }
    }
}