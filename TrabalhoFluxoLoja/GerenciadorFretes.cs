using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public static class GerenciadorFretes
    {
        private static  List<FreteEstado> fretes = new List<FreteEstado> {
        new FreteEstado(1, "Acre", 50.00),
        new FreteEstado(2, "Alagoas", 30.00),
        new FreteEstado(3, "Amapá", 35.00),
        new FreteEstado(4, "Amazonas", 45.00),
        new FreteEstado(5, "Bahia", 25.00),
        new FreteEstado(6, "Ceará", 35.00),
        new FreteEstado(7, "Distrito Federal", 25.00),
        new FreteEstado(8, "Espírito Santo", 30.00),
        new FreteEstado(9, "Goiás", 35.00),
        new FreteEstado(10, "Mato Grosso", 45.00),
        new FreteEstado(11, "Mato Grosso do Sul", 25.00),
        new FreteEstado(12, "Minas Gerais", 35.00),
        new FreteEstado(13, "Pará ", 50.00),
        new FreteEstado(14, "Paraíba", 30.00),
        new FreteEstado(15, "paraná", 35.00),
        new FreteEstado(16, "Pernambuco", 45.00),
        new FreteEstado(17, "Piauí", 25.00),
        new FreteEstado(18, "Rio de Janeiro", 35.00),
        new FreteEstado(19, "Rio Grande do Norte", 50.00),
        new FreteEstado(20, "Rio Grande do Sul", 30.00),
        new FreteEstado(21, "Rondônia ", 35.00),
        new FreteEstado(22, "Roraima ", 45.00),
        new FreteEstado(23, "Santa Catarina ", 30.00),
        new FreteEstado(24, "São Paulo", 39.00),
        new FreteEstado(25, "Sergipe", 36.00),
        new FreteEstado(26, "Tocantis", 33.00),
        new FreteEstado(27, "Maranhão", 31.00),
        };

        public static void Estados()
        {
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
        }

        public static double ConsultarFretePorId(int id)
        {
            foreach (var frete in fretes)
            {
                if (frete.Id == id)
                {
                    return frete.ValorFrete;
                }
            }

            return -1;
        }

    }
}
