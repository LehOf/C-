using System;

namespace TreinamentoOOP88
{
    class Program
    {
        static void Main(string[] args)
        {
            // Funções com string
            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper(); // Tudo maiusculo
            string s2 = original.ToLower(); // Tudo minusculo
            string s3 = original.Trim(); // Apagar espaços em branco
            int n1 = original.IndexOf("bc"); 
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x'); // Trocar caracter 'a' pelo 'x'
            string s7 = original.Replace("abc", "xy"); // Trocar caracteres
            bool b1 = String.IsNullOrEmpty(original); // Verificar se têm elemento nullo
            bool b2 = String.IsNullOrWhiteSpace(original); // Verificar se têm espaço em branco

            // Imprimindo e demonstrando
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
