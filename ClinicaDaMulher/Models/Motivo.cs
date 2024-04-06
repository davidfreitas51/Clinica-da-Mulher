using System.ComponentModel.DataAnnotations;

namespace ClinicaDaMulher.Models
{
    public class Motivo
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
