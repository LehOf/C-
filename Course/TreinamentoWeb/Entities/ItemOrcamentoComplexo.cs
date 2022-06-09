using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;


namespace TreinamentoWeb.Entities
{
    class ItemOrcamentoComplexo : IAnimalOrcamento
    {

        public string Animal { get; set; }
        public double Orcamento { get; set; }
        public string Vacina { get; set; }


        public ItemOrcamentoComplexo(string animal, double orcamento)
        {
            Animal = animal;
            Orcamento = orcamento;
        }

        public ItemOrcamentoComplexo(string animal, double orcamento, string vacinaW)
        {
            string Animal = animal;
            double Orcamento = orcamento;
            string Vacina = vacinaW;

        }

        public void orcamentoGastosAnimal(List<ItemOrcamentoComplexo> lista, ItemOrcamentoComplexo item)
        {
            lista = new List<ItemOrcamentoComplexo>();
            lista.Add(item);

            foreach (ItemOrcamentoComplexo i in lista)
            {
                Console.WriteLine(i);
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOME DO ANIMAL: " + Animal);
            sb.AppendLine("ORÇAMENTO DO ANIMAL: " + Orcamento.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
