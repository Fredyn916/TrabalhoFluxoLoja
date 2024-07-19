using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFluxoLoja
{
    public static class HistoricoDeCompras
    {
        public static void HistoricoDeComprasRealizadas(Usuario x)
        {
            int qntVenda = x.Compras.Count();
            if (qntVenda > 0)
            {
                int ContadorVendas = 0;
                foreach (Venda compra in x.Compras)
                {
                    ContadorVendas++;
                    Console.WriteLine($"<-------- Compra {ContadorVendas} --------->");
                    compra.DetalhesDaVenda();
                    Console.WriteLine($"<--------------------------->");
                }
            }
            else if(qntVenda == 0)
            {
                Console.WriteLine("Não existem compras realizadas nesse Usuário");
            }
        }
    }
}
