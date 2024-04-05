using System.ComponentModel.DataAnnotations;

namespace ClinicaDaMulher.Models
{
    public class Razao
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
