using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication1.Models
{
    public partial class sampleDB1Context : DbContext
    {
        public sampleDB1Context()
        {
        }

        public sampleDB1Context(DbContextOptions<sampleDB1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Depart> Departs { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Emp> Emps { get; set; }
        public virtual DbSet<Employe> Employes { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Sample> Samples { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-RCN3MKKD;Initial Catalog=sampleDB1;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Depart>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("depart");

                entity.Property(e => e.Department)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("department");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("department");

                entity.Property(e => e.Department1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("department");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Emp");

                entity.Property(e => e.Department)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("department");

                entity.Property(e => e.Empname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("empname");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Salary)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("salary");
            });

            modelBuilder.Entity<Employe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employe");

                entity.Property(e => e.Departmentid).HasColumnName("departmentid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee");

                entity.Property(e => e.Empname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("empname");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Sample>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sample");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("student");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rollno).HasColumnName("rollno");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
