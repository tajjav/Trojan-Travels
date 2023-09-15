﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentManagementSystem.Data.Data;

#nullable disable

namespace StudentManagementSystem.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentManagementSystem.Lib.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Instructor")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1050,
                            Credits = 3,
                            Instructor = "John Dean",
                            Title = "Internet Application 2"
                        },
                        new
                        {
                            Id = 4022,
                            Credits = 3,
                            Instructor = "David Doe",
                            Title = "Java"
                        },
                        new
                        {
                            Id = 4041,
                            Credits = 3,
                            Instructor = "Juan Kate",
                            Title = "Object Oriented Sofware Development"
                        },
                        new
                        {
                            Id = 1045,
                            Credits = 4,
                            Instructor = "Cheryl Smith",
                            Title = "SQL Server"
                        },
                        new
                        {
                            Id = 3141,
                            Credits = 4,
                            Instructor = "Alex Byron",
                            Title = "Introduction to C#"
                        },
                        new
                        {
                            Id = 2021,
                            Credits = 3,
                            Instructor = "Kate Bill",
                            Title = "Internet Application 1"
                        },
                        new
                        {
                            Id = 2042,
                            Credits = 3,
                            Instructor = "Fred More",
                            Title = "jQuery"
                        });
                });

            modelBuilder.Entity("StudentManagementSystem.Lib.Models.Enrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseID = 1050,
                            Grade = 0,
                            StudentID = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseID = 4022,
                            Grade = 2,
                            StudentID = 1
                        },
                        new
                        {
                            Id = 3,
                            CourseID = 4041,
                            Grade = 1,
                            StudentID = 1
                        },
                        new
                        {
                            Id = 4,
                            CourseID = 1045,
                            Grade = 1,
                            StudentID = 2
                        },
                        new
                        {
                            Id = 5,
                            CourseID = 3141,
                            Grade = 5,
                            StudentID = 2
                        },
                        new
                        {
                            Id = 6,
                            CourseID = 2021,
                            Grade = 5,
                            StudentID = 2
                        },
                        new
                        {
                            Id = 7,
                            CourseID = 1050,
                            StudentID = 3
                        },
                        new
                        {
                            Id = 8,
                            CourseID = 1050,
                            StudentID = 4
                        },
                        new
                        {
                            Id = 9,
                            CourseID = 4022,
                            Grade = 5,
                            StudentID = 4
                        });
                });

            modelBuilder.Entity("StudentManagementSystem.Lib.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("ImageFile")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Initials")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EnrollmentDate = new DateTime(1998, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Andy",
                            Gender = 0,
                            ImageFile = "AndyAYoung.jpg",
                            Initials = "A",
                            LastName = "Young"
                        },
                        new
                        {
                            Id = 2,
                            EnrollmentDate = new DateTime(2000, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jane",
                            Gender = 1,
                            ImageFile = "JaneYHarriman.jpg",
                            Initials = "Y",
                            LastName = "Harriman"
                        },
                        new
                        {
                            Id = 3,
                            EnrollmentDate = new DateTime(1997, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Kate",
                            Gender = 2,
                            ImageFile = "KateGGeorge.jpg",
                            Initials = "G",
                            LastName = "George"
                        },
                        new
                        {
                            Id = 4,
                            EnrollmentDate = new DateTime(2003, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Marc",
                            Gender = 0,
                            ImageFile = "MarcHBredd.jpg",
                            Initials = "H",
                            LastName = "Bredd"
                        });
                });

            modelBuilder.Entity("StudentManagementSystem.Lib.Models.Enrollment", b =>
                {
                    b.HasOne("StudentManagementSystem.Lib.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementSystem.Lib.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentManagementSystem.Lib.Models.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("StudentManagementSystem.Lib.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
