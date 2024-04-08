using System.ComponentModel.DataAnnotations;

namespace ClinicaDaMulher.Models
{
    public class Consulta
    {
        [Key]
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string CPF {  get; set; }
        public string Motivo { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
    }
}
