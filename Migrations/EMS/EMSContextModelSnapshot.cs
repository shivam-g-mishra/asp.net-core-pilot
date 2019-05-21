﻿// <auto-generated />
using System;
using Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CoreEMS.Migrations.EMS
{
    [DbContext(typeof(EMSContext))]
    partial class EMSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ContosoPets.Api.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CoreEMS.Models.Book", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("ISBN");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("CoreEMS.Models.Department", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("CoreEMS.Models.Guardian", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("Photo");

                    b.Property<string>("Role");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Guardians");
                });

            modelBuilder.Entity("CoreEMS.Models.Lecture", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("NumberOfClasses");

                    b.Property<string>("RoomNumber");

                    b.Property<string>("SectionId")
                        .IsRequired();

                    b.Property<string>("SubjectId")
                        .IsRequired();

                    b.Property<string>("TeacherId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("CoreEMS.Models.Section", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("SemesterId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("SemesterId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("CoreEMS.Models.Semester", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DepartmentId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("CoreEMS.Models.Student", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("BloodGroup");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<int>("Gender");

                    b.Property<string>("GuardianId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("Photo");

                    b.Property<string>("RegistrationNumber");

                    b.Property<string>("Role");

                    b.Property<string>("RollNumber");

                    b.Property<string>("SectionId");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("GuardianId")
                        .IsUnique();

                    b.HasIndex("SectionId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CoreEMS.Models.Subject", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("SemesterId")
                        .IsRequired();

                    b.Property<string>("SubjectCode")
                        .IsRequired();

                    b.Property<int>("SubjectType");

                    b.HasKey("Id");

                    b.HasIndex("SemesterId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("CoreEMS.Models.Teacher", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Designation")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<int>("Gender");

                    b.Property<DateTime>("JoiningDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("Photo");

                    b.Property<string>("Role");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("CoreEMS.Models.Book", b =>
                {
                    b.HasOne("CoreEMS.Models.Subject")
                        .WithMany("ReferenceBooks")
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("CoreEMS.Models.Lecture", b =>
                {
                    b.HasOne("CoreEMS.Models.Section", "Section")
                        .WithMany("Lectures")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreEMS.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreEMS.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreEMS.Models.Section", b =>
                {
                    b.HasOne("CoreEMS.Models.Semester", "Semester")
                        .WithMany("Sections")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreEMS.Models.Semester", b =>
                {
                    b.HasOne("CoreEMS.Models.Department", "Department")
                        .WithMany("Semesters")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("CoreEMS.Models.Student", b =>
                {
                    b.HasOne("CoreEMS.Models.Guardian", "Guardian")
                        .WithOne("Student")
                        .HasForeignKey("CoreEMS.Models.Student", "GuardianId");

                    b.HasOne("CoreEMS.Models.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("CoreEMS.Models.Subject", b =>
                {
                    b.HasOne("CoreEMS.Models.Semester", "Semester")
                        .WithMany()
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
