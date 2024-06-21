using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class FreteEstado
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public double ValorFrete { get; set; }

        public FreteEstado(int id, string estado, double valorFrete)
        {
            Id = id;
            Estado = estado;

        }

    }
}
