using System;
using System.Threading;
using Treinamento.Entities;

namespace Trinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora c1 = new Calculadora();

            Console.Write("QUANTAS CONTAS SERÃO EFETUADAS: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("----------------------- BEM VINDO A CALCULADORA ----------------------- ");
                Console.WriteLine(" ");
                Console.Write("DIGITE O PRIMEIRO DIGITO: ");
                double operador1 = double.Parse(Console.ReadLine());
                Console.Write("DIGITE O SEGUNDO DIGITO: ");
                double operador2 = double.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.Write("QUAL OPERAÇÃO DESEJA REALIZAR: (SOMAR/SUBTRAIR/MULTIPLICAR/DIVIDIR)");
                string resposta = Console.ReadLine();
                Console.WriteLine("");

                switch (resposta)
                {
                    case "SOMAR":
                        Console.WriteLine("SOMANDO OPERAÇÃO: ");
                        Thread.Sleep(2000);
                        Console.WriteLine("A SOMA É: " + c1.Somar(operador1, operador2));
                        Console.Write("\n");
                        break;

                    case "SUBTRAIR":
                        Console.WriteLine("SUBTRAINDO OPERAÇÃO: ");
                        Thread.Sleep(2000);
                        Console.WriteLine("A SUBTRAÇÃO É: " + c1.Subtrair(operador1, operador2));
                        Console.Write("\n");
                        break;

                    case "MULTIPLICAR":
                        Console.WriteLine("MULTIPLICANDO OPERAÇÃO: ");
                        Thread.Sleep(2000);
                        Console.Write("A MULTIPLICAÇÃO É: " + c1.Multiplicar(operador1, operador2));
                        Console.Write("\n");
                        break;

                    case "DIVIDIR":
                        Console.WriteLine("DIVIDINDO OPERAÇÃO: ");
                        Thread.Sleep(2000);
                        Console.Write("A DIVISÃO É: " + c1.Dividir(operador1, operador2));
                        Console.Write("\n");
                        break;

                    default:
                        Console.WriteLine("ENTRADA INVÁLIDA");
                        Console.WriteLine("");
                        break;
                }
            }



        }
    }
}











