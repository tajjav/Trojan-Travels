using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.API.Models;

namespace StudentManagementSystem.API.Data;

public partial class InstructorDbContext : DbContext
{
    public InstructorDbContext()
    {
    }

    public InstructorDbContext(DbContextOptions<InstructorDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Instructor> Instructors { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=Localhost;Database=InstructorDB;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Instruct__3214EC273901B404");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Initials).HasMaxLength(10);
            entity.Property(e => e.LastName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
