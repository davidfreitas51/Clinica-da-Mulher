using Microsoft.EntityFrameworkCore;
using ClinicaDaMulher.Models;

namespace ClinicaDaMulher.Data
{
    public class ClinicaDaMulherContext : DbContext, IClinicaDaMulherContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Motivo> Motivos { get; set; }
        public DbSet<Consulta> Consultas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=clinicaDaMulher.db");
            
        }
        public void CriarEntidade<T>(T entidade) where T : class
        {
            Set<T>().Add(entidade);
            SaveChanges();
        }
    }
}