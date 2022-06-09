using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            // PARA INSERIR VALORES EXISTE DUAS MANEIRAS

            cookies.Add("nome", "Maria");

            cookies["nome"] = "Maria"; // JEITO MAIS COMODO

            cookies["email"] = "Maria@hotmail.com";

            // QUE A CLASSE DICTIONARRY NÃO ACEITA REPETIÇÃO

            cookies["phone"] = "19987654678";
            cookies["phone"] = "19977639934";

            // COMO NÃO ACEITA REPETIÇÃO A CHAVE PHONE PASSA A VALER O ÚLTIMO VALOR QUE RECEBEU

            // IMPRIMINDO 

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            // REMOVENDO ITENS

            //cookies.Remove("Email");
            //Console.WriteLine(cookies["Email"]); // O PROGRAMA QUEBRA POIS TENTA ACESSAR UMA CHAVE QUE NÃO EXISTE

            // PARA ISSO COLOQUE UM BLOCO TRY CATCH OU TESTA EXCEÇÃO

            if (cookies.ContainsKey("email")){
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            // PARA VERIFICAR O TAMANHO

            Console.WriteLine("Size: " + cookies.Count);

            // PERCORRENDO UM DICTIONARY

            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value); // PERCORRENDO OS PARES DO TIPO STRING E ACESSANDO A CHAVE E ACESSANDO VALOR
            }

            // PERCORRENDO DA MESMA FORMA MAS DE UM JEITO MENOS VERBOSO

            foreach (var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}
