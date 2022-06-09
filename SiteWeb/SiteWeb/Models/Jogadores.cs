using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiteWeb.Models
{
    [Table("Jogadores")]
    public class Jogadores
    {
        [Column("Nome")]

        public string Nome { get; set; }

        [Column("Idade")]

        public int Idade { get; set; }
    }
}
