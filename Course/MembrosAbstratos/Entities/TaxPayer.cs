using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer()
        {
        }

        public TaxPayer(string name, double anuallncome)
        {
            Name = name;
            AnualIncome = anuallncome;

        }

        abstract public double Tax();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Name + " $ " + Tax().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}