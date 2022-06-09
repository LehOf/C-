using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoOOP13
{
    class Calculator
    {
        // Criar uma função estática que utiliza a palavra "params" para receber uma quantia variável de valor
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
