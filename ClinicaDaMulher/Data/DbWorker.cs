using ClinicaDaMulher.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicaDaMulher.Data
{
    internal class DbWorker
    {
        private readonly IClinicaDaMulherContext _context;

        public DbWorker(IClinicaDaMulherContext context)
        {
            _context = context;

        }
        public void AdicionarCliente(Cliente cliente)
        {
        }
    }
}
