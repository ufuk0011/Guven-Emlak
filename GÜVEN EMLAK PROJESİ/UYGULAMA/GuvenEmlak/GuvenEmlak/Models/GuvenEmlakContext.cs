using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GuvenEmlak.Models;

public partial class GuvenEmlakContext : DbContext
{
    public GuvenEmlakContext()
    {
    }

    public GuvenEmlakContext(DbContextOptions<GuvenEmlakContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<House> Houses { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("data source=C:\\\\\\\\GÜVEN EMLAK PROJESİ\\\\\\\\VERİ TABANI\\\\\\\\GuvenEmlak.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");

            entity.HasIndex(e => e.Id, "IX_Employee_Id").IsUnique();
        });

        modelBuilder.Entity<House>(entity =>
        {
            entity.HasIndex(e => e.Id, "IX_Houses_Id").IsUnique();
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.ToTable("Report");

            entity.HasIndex(e => e.Id, "IX_Report_Id").IsUnique();

            entity.HasOne(d => d.Employee).WithMany(p => p.Reports).HasForeignKey(d => d.EmployeeId);

            entity.HasOne(d => d.House).WithMany(p => p.Reports).HasForeignKey(d => d.HouseId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.Id, "IX_Users_Id").IsUnique();

            entity.HasIndex(e => e.NicName, "IX_Users_NicName").IsUnique();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
