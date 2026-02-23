using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LinqToEntities.Models;

public partial class EmpManagementContext : DbContext
{
    public EmpManagementContext()
    {
    }

    public EmpManagementContext(DbContextOptions<EmpManagementContext> options)
        : base(options)
    {
    }


    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=EmpManagement;Username=postgres;Password=karthik;TrustServerCertificate=True;");

        optionsBuilder.EnableSensitiveDataLogging();
    }
        

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Departmentid).HasName("department_pkey");

            entity.ToTable("department");

            entity.HasIndex(e => e.Departmentname, "department_departmentname_key").IsUnique();

            entity.Property(e => e.Departmentid).HasColumnName("departmentid");
            entity.Property(e => e.Createdat)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdat");
            entity.Property(e => e.Departmentname)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("departmentname");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .HasColumnName("location");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Employeeid).HasName("employee_pkey");

            entity.ToTable("employee");

            entity.HasIndex(e => e.Email, "employee_email_key").IsUnique();

            entity.Property(e => e.Employeeid).HasColumnName("employeeid");
            entity.Property(e => e.Createdat)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdat");
            entity.Property(e => e.Departmentid).HasColumnName("departmentid");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Hiredate).HasColumnName("hiredate");
            entity.Property(e => e.Isactive)
                .HasDefaultValue(true)
                .HasColumnName("isactive");
            entity.Property(e => e.Lastname)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("lastname");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.Salary)
                .HasPrecision(10, 2)
                .HasColumnName("salary");

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
                .HasForeignKey(d => d.Departmentid)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_department");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
