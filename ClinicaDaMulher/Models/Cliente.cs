﻿using System.ComponentModel.DataAnnotations;

namespace ClinicaDaMulher.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
    }
}
