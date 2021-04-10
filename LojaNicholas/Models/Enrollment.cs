using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaNicholas.Models
{
    public class Enrollment
    {
        
        public int EnrollmentID { get; set; }
        public int VendedoresID { get; set; }
        public int ClientesID { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual Vendedores Vendedor { get; set; }
    }
}

