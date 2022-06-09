using System;

namespace TreinamentoOOP10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando o tipo struct
            Point p;

            // Inicializando valores
            p.x = 10;
            p.y = 20;

            // Imprimindo na tela
            Console.WriteLine(p);

            // Mesmo sendo struct inicializar porque se instanciar apenas inicializa com valor 0 as variáveis
            p = new Point();
            Console.WriteLine(p);

        }
    }
}
