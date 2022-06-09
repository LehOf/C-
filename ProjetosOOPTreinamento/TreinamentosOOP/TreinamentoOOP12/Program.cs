using System;

namespace TreinamentoOOP12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pegando quantia de quartos que serão alugados
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Instanciar o vetor
            Contato[] vet = new Contato[10];

            // Percorrendo o vetor e preenchendo as posições com o contato da pessoa
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Aluguel" + " #" + i + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();
                vet[quarto] = new Contato(nome, email);
            }

            // Percorrendo as posições e visualizando os valores
            for (int i = 0; i < 10; i++)
            {
                if(vet[i] != null)
                {
                    Console.WriteLine("Quartos ocupados: " + "\n"
              + i + ": " + vet[i]);
                }
            }
        }
    }
}
