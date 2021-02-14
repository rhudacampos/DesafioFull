﻿// <auto-generated />
using System;
using DesafioFULL.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DesafioFULL.Repositorio.Migrations
{
    [DbContext(typeof(DesafioFULLContexto))]
    [Migration("20210214001701_adicionandoBancoDados")]
    partial class adicionandoBancoDados
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DesafioFULL.Dominio.Entidades.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11) CHARACTER SET utf8mb4")
                        .HasMaxLength(11);

                    b.Property<string>("Fone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("SobreNome")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("DesafioFULL.Dominio.Entidades.Titulo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("ClienteId")
                        .HasColumnType("bigint");

                    b.Property<int>("DiasEmAtraso")
                        .HasColumnType("int");

                    b.Property<decimal>("PerJuros")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("PerMulta")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("QtdeParcelas")
                        .HasColumnType("int");

                    b.Property<decimal>("VlrCorrigido")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("VlrOriginal")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Titulos");
                });

            modelBuilder.Entity("DesafioFULL.Dominio.Entidades.TituloParcela", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("NumParcela")
                        .HasColumnType("int");

                    b.Property<long>("TituloId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Vencimento")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("VlrCorrigido")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("VlrOriginal")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("TituloId");

                    b.ToTable("TituloParcelas");
                });

            modelBuilder.Entity("DesafioFULL.Dominio.Entidades.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(400) CHARACTER SET utf8mb4")
                        .HasMaxLength(400);

                    b.Property<string>("SobreNome")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("DesafioFULL.Dominio.Entidades.Titulo", b =>
                {
                    b.HasOne("DesafioFULL.Dominio.Entidades.Cliente", "Cliente")
                        .WithMany("Titulos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DesafioFULL.Dominio.Entidades.TituloParcela", b =>
                {
                    b.HasOne("DesafioFULL.Dominio.Entidades.Titulo", "Titulo")
                        .WithMany("Parcelas")
                        .HasForeignKey("TituloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
