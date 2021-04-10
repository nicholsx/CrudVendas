using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LojaNicholas.Models
{
    public class Vendedores
    {
        public int Id { get; set; }
        [Display(Name = "Código do Vendedor")]
        public string CdVend { get; set; }
        [Display(Name = "Nome")]
        public string DsNome { get; set; }
        [Display(Name = "Cód. Tabela Preço")]
        public int CdTab { get; set; }
        [Display(Name = "Data Nascimento")]
        public DateTime DtNasc { get; set; }
    }
}
