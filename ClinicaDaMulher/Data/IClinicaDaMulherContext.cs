using ClinicaDaMulher.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicaDaMulher.Data
{
    public interface IClinicaDaMulherContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Motivo> Motivos { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        int SaveChanges();
        void CriarEntidade<T>(T entidade) where T : class;
    }
}
