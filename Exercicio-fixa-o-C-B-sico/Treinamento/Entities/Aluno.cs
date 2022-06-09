using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Treinamento.Entities
{
    class Aluno
    {
        public string Nome { get; set; }
        public int ID { get; set; }
        public List<Aluno> aluno { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }

        public double Nota3 { get; set; }

        public Aluno()
        {

        }

        public Aluno(string nome, int iD, double nota1, double nota2, double nota3)
        {
            Nome = nome;
            ID = iD;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }


        public double Media()
        {
            double valor = (Nota1 + Nota2 + Nota3) / 3;
            return valor;

        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("Nome: " + Nome + "\n");
            sb.Append("ID: " + ID + "\n");
            if (Media() >= 7)
            {
                sb.Append("Média: " + Media().ToString("F1", CultureInfo.InvariantCulture) + " ALUNO APROVADO" + "\n");
            }
            else if (Media() < 7)
            {
                sb.Append("Média: " + Media().ToString("F1", CultureInfo.InvariantCulture) + " ALUNO REPROVADO" + "\n");
            }
            return sb.ToString();


        }
    }
}
