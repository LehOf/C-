using System;
using System.Globalization;

namespace TreinamentoOOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando
            Retangulo x = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            x.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            x.Area();
            x.Perimetro();
            x.Diagonal();

            Console.WriteLine(x);

        }
    }
}
