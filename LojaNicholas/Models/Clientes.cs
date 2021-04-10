using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LojaNicholas.Models
{
    public class Clientes
    {
        
        public int Id { get; set; }
        [Display(Name = "Código do Cliente")]
        public string CdCl { get; set; }
        [Display(Name = "Nome")]
        public string DsNome { get; set; }
        [Display(Name = "Tipo de Pessoa - PF ou PJ")]
        public string IdTipo { get; set; }
        [Display(Name = "Vendedor")]
        public string CdVend { get; set; }
        [Display(Name = "Limite de Credito")]
        public decimal DsLim { get; set; }

    }
}
