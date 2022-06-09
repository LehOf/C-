using System;
using System.Globalization;

namespace TreinamentoOOP5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando
            Funcionario funcionario = new Funcionario();

            // Pegando dados
            Console.Write("Nome: ");
            funcionario.nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.salarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("");

            // Dados do funcionario
            Console.WriteLine("Funcionário: " + funcionario);
            Console.WriteLine("");

            // Pegando porcentagem
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);
            Console.WriteLine("");

            // Dados atualizados
            Console.WriteLine("Dados atualizados: " + funcionario);






        }
    }
}
