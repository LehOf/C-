using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento.Entities
{
    class Calculadora
    {
        public double Operador1 { get; set; }
        public double Operador2 { get; set; }

        public Calculadora()
        {

        }

        public Calculadora(double operador1, double operador2)
        {
            Operador1 = operador1;
            Operador2 = operador2;
        }

        public double Somar(double operador1, double operador2)
        {
            double valor = operador1 + operador2;
            return valor;
        }

        public double Subtrair(double operador1, double operador2)
        {
            double valor = operador1 - operador2;
            return valor;
        }

        public double Multiplicar(double operador1, double operador2)
        {
            double valor = operador1 * operador2;
            return valor;
        }

        public double Dividir(double operador1, double operador2)
        {
            double valor = operador1 / operador2;
            return valor;
        }
    }
}
