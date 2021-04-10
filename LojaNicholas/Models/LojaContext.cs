using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaNicholas.Models
{
    public class LojaContext : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Vendedores> Vendedores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = LojaNicholas; Integrated Security = True");
        }
       
    }
}
