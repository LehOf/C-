using System;
using System.Collections.Generic;
using TreinamentoWeb.Interface;
using TreinamentoWeb.Entities;


namespace TreinamentoWeb
{

    interface IAnimalOrcamento : IAnimal
    {
        public void orcamentoGastosAnimal(List<ItemOrcamentoComplexo> lista, ItemOrcamentoComplexo item);

    }
}
