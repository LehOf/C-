using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoOOP11
{
    class Produto
    {
        public string nome { get; set; }
        public double price{ get; set; }

        public Produto(string nome,double price)
        {
            this.nome = nome;
            this.price = price;
        }

    }
}
