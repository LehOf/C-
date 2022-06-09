using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpnditures { get; set; }

        public Individual()
        {

        }

        public Individual(string name, double anuallncome, double healthExpnditures) : base(name, anuallncome)
        {
            HealthExpnditures = healthExpnditures;

        }

        public override double Tax()
        {
            double valor;
            double valor2 = (HealthExpnditures * 0.50);

            if (AnualIncome < 20000)
            {
                valor = (AnualIncome * 0.15) - valor2;

            }
            else
            {
                valor = (AnualIncome * 0.25) - valor2;
            }
            return valor;
        }

    }
}