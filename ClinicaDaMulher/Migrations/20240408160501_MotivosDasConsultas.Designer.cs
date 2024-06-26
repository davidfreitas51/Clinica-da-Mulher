﻿// <auto-generated />
using System;
using ClinicaDaMulher.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClinicaDaMulher.Migrations
{
    [DbContext(typeof(ClinicaDaMulherContext))]
    [Migration("20240408160501_MotivosDasConsultas")]
    partial class MotivosDasConsultas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("ClinicaDaMulher.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ClinicaDaMulher.Models.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("TEXT");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("ClinicaDaMulher.Models.Motivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Motivos");
                });

            modelBuilder.Entity("ClinicaDaMulher.Models.Consulta", b =>
                {
                    b.HasOne("ClinicaDaMulher.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
