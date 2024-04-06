using System.ComponentModel.DataAnnotations;

namespace ClinicaDaMulher.Models
{
    public class Consulta
    {
        [Key]
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Motivo Razao { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [DataType(DataType.Time)]
        public DateTime Hora { get; set; }
    }
}
