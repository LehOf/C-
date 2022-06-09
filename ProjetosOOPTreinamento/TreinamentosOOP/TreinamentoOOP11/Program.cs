using System;
using System.Globalization;

namespace TreinamentoOOP11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Coletando quantidade de posições
            int n = int.Parse(Console.ReadLine());

            // Instanciando meu vetor
            Produto[] vet = new Produto[n];

            // Percorre as posições inserindo valores
            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto(nome, preco);
            }

            // Criando uma variável de soma
            double soma = 0.0;

            // Percorre o vetor para calcular a media
            for (int i = 0; i < n; i++)
            {
                soma += vet[i].price;

            }

            // Variável para media soma / pela quantidade de posições
            double media = soma / n;
            Console.WriteLine("AVERAGE PRICE = " + media.ToString("F2",CultureInfo.InvariantCulture));



        }
    }
}
