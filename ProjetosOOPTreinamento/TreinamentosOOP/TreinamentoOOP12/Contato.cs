using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoOOP12
{
    class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Contato(string Nome, string Email)
        {
            this.Nome = Nome;
            this.Email = Email;    
        }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
