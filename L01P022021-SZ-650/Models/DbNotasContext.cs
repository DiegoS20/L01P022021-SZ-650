﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace L01P022021_SZ_650.Models;

public partial class DbNotasContext : DbContext
{
    public DbNotasContext()
    {
    }

    public DbNotasContext(DbContextOptions<DbNotasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alumno> Alumnos { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Facultade> Facultades { get; set; }

    public virtual DbSet<Materia> Materias { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source = LOCALHOST; Initial Catalog = db_notas; User id = Diego; Password = admin; Connect Timeout = 120; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alumno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__alumnos__3213E83F5234348F");

            entity.ToTable("alumnos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.Dui).HasColumnName("dui");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__departam__3213E83F549E478F");

            entity.ToTable("departamentos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Departamento1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("departamento");
        });

        modelBuilder.Entity<Facultade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__facultad__3213E83F89757F73");

            entity.ToTable("facultades");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Facultad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("facultad");
        });

        modelBuilder.Entity<Materia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__materias__3213E83F48D42B4E");

            entity.ToTable("materias");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Materia1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("materia");
            entity.Property(e => e.UnidadesValorativas).HasColumnName("unidades_valorativas");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
