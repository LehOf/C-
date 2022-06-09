using System;
using System.Globalization;

namespace TreinamentoOOP5
{
    class Funcionario
    {
        public String nome;
        public double salarioBruto;
        public double imposto;

        public double SalarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            double valor = (porcentagem / 100) * salarioBruto;
            salarioBruto = salarioBruto + valor;

        }

        public override String ToString()
        {
            return nome
                + ", " + " $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}