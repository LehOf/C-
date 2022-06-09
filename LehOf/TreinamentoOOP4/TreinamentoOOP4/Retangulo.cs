using System;
using System.Globalization;

namespace TreinamentoOOP4
{
    class Retangulo
    {
        //Atributos
        public double Largura;
        public double Altura;

        // Método Area
        public double Area()
        {
            return Largura * Altura;
        }

        // Método Perimetro
        public double Perimetro()
        {
            double p;
            return  p = 2 * (Largura + Altura);
        }

        // Método Diagonal
        public double Diagonal()
        {
            double d = Math.Sqrt(Math.Pow(Largura,2) + Math.Pow(Altura,2));
                return d;
        }

        // ToString
        public override string ToString()
        {
            return "AREA = " + Area().ToString("F2",CultureInfo.InvariantCulture) +
                " \n" +
                "PERÍMETRO = " + Perimetro().ToString("F2",CultureInfo.InvariantCulture) +
                "\n" +
                "DIAGONAL = " + Diagonal().ToString("F2",CultureInfo.InvariantCulture);

                

            
        }
    }
}
