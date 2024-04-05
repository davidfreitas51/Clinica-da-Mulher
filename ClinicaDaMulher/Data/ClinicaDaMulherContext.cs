using Microsoft.EntityFrameworkCore;
using ClinicaDaMulher.Models;

namespace ClinicaDaMulher.Data
{
    public class ClinicaDaMulherContext : DbContext, IClinicaDaMulherContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Razao> Razoes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=nomeDoArquivo.db");
        }
        public void CriarCliente(Cliente cliente)
        {

        }
    }
}
