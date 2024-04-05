using System.ComponentModel.DataAnnotations;

namespace ClinicaDaMulher.Models
{
    public class Consulta
    {
        public Cliente Cliente { get; set; }
        public Razao Razao { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [DataType(DataType.Time)]
        public DateTime Hora { get; set; }
    }
}
