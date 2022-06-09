using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TreinamentoOOP9
{
    class ContaBancaria
    {
        // Atributos
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        // Construtor padrão
        public ContaBancaria()
        {

        }

        // Construtor que pede todos os dados
        public ContaBancaria(int Numero, string Titular, double Saldo)
        {
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = Saldo;
        }

        // Método de saque
        public void Saque(double valor1)
        {
            Saldo -= valor1;
            Saldo -= 5;

        }

        // Método de depósito
        public void Deposito(double valor2) => Saldo += valor2;

        // ToString

        public override string ToString()
        {
            return "Conta: " + Numero + ","
                + " Titular: " + Titular + ","
                + " Saldo: " + " $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }

    }

}
