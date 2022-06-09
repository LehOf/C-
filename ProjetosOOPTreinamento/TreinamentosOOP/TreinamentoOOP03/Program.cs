using System;
using System.Globalization;

namespace TreinamentoOOP3
{
    class Program
    {
        static void Main(string[] args)
        {
 
            // Pedindo os dados
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");

            // Instanciando Construtor sobrecarga 1 (quantidade com valor fixo de 5)
            Produto x = new Produto(nome, preco);

            // Instanciando Construtor sobrecarga 2 (construtor vazio)
            Produto x1 = new Produto();

            // Dados do produto
            Console.WriteLine("Dados do produto: " + x);
            Console.WriteLine("");

            // Adicionando
            Console.Write("Digite a quantidade de produto a serem adicionados ao estoque: ");
            int quantity1 = int.Parse(Console.ReadLine());
            x.AdicionarProdutos(quantity1);
            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + x);
            Console.WriteLine("");

            // Removendo
            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            int quantity2 = int.Parse(Console.ReadLine());
            x.RemoverProdutos(quantity2);
            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + x);
            

        }
    }
}
