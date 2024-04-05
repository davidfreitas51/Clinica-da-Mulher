using Microsoft.EntityFrameworkCore;
using ClinicaDaMulher.Models;

namespace ClinicaDaMulher.Data
{
    public interface IClinicaDaMulherContext
    {
        void CriarCliente(Cliente cliente);
    }
}
