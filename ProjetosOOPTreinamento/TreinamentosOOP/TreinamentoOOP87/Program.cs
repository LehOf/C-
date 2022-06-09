using System;

namespace TreinamentoOOP87
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazendo com estrutura condicional
            double preco = 34.5;
            double desconto;
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }

            // Condicional ternária
            double preco2 = 34.5;
            double desconto2 = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
        }
    }
}
