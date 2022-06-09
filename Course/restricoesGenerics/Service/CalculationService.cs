using System;
using System.Collections.Generic;
using System.Text;

namespace restricoesGenerics
{
    class CalculationService
    {
        // Método do tipo T (GENÉRICO) que recebe uma lista como parâmetro essa lista é (GENÉRICA)
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                // Não permite que a lista esteja vazia
                throw new ArgumentException("The list can not be empty");
            }

            /*Declara uma variável se i > que a variável que recebe a lista na posição 0 essa variável passa
            a receber a lista na posição i*/
            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            // retorna a variável que guarda a lista na posição i
            return max;
        }

        
        

        
    }
}
