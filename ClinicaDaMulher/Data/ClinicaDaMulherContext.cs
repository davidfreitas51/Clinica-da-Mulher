﻿using Microsoft.EntityFrameworkCore;
using ClinicaDaMulher.Models;

namespace ClinicaDaMulher.Data
{
    public class ClinicaDaMulherContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Razao> Razoes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=clinicaDaMulher.db");
        }
    }
}