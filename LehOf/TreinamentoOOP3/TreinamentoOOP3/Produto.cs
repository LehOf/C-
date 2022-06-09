using System;
using System.Globalization;

namespace TreinamentoOOP3
{
    class Produto
    {
        // Atributos da classe
        public String nome;
        public double preco;
        public int quantidade;

        // Gerando o construtor
        public Produto(string Asnome, double Aspreco, int Asquantidade)
        {
            nome = Asnome;
            preco = Aspreco;
            quantidade = Asquantidade;

        }

        //Gerando construtor vazio
        public Produto()
        {
        }

        // Gerando o construtor segundário
        public Produto(string Asnome, double Aspreco)
        {
            nome = Asnome;
            preco = Aspreco;
            quantidade = 5; // Pode atribuir qualquer valor para ser iniciado ou nãoa tribuir nada o 0 é boa prática de programação
        }

        // Método valorTotalemEstoque
        public double ValorTotalemEstoque()
        {
            return quantidade * preco;
        }

        // Método adicionarProdutos
        public void AdicionarProdutos(int quantity)
        {
            quantidade = quantidade + quantity;
        }

        // Método RemoverProdutos
        public void RemoverProdutos(int quantity)
        {
            quantidade = quantidade - quantity;
        }

        // ToString
        public override string ToString()
        {
            return nome + ", $ " + preco.ToString("F2",CultureInfo.InvariantCulture)
            + ", "
            + quantidade
            + " unidades, Total: $ "
            + ValorTotalemEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
