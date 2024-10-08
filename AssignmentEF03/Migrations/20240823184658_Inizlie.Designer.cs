﻿// <auto-generated />
using System;
using AssignmentEF03.dbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssignmentEF03.Migrations
{
    [DbContext(typeof(ITIDBcontext))]
    [Migration("20240823184658_Inizlie")]
    partial class Inizlie
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AssignmentEF03.Entites.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Duration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("AssignmentEF03.Entites.Course_Inst", b =>
                {
                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("inst_ID")
                        .HasColumnType("int");

                    b.Property<string>("evaluate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Course_ID", "inst_ID");

                    b.ToTable("Course_Insts");
                });

            modelBuilder.Entity("AssignmentEF03.Entites.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ins_ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("AssignmentEF03.Entites.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Bouns")
                        .HasColumnType("float");

                    b.Property<int>("Dept_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("HourRate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Dept_ID")
                        .IsUnique();

                    b.HasIndex("Ins_ID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("AssignmentEF03.Entites.Stud_Course", b =>
                {
                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("Stud_ID")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("Course_ID", "Stud_ID");

                    b.ToTable("Stud_Courses");
                });

            modelBuilder.Entity("AssignmentEF03.Entites.Students", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentsId")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentsId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("AssignmentEF03.Entites.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Top_ID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Top_ID")
                        .IsUnique()
                        .HasFilter("[Top_ID] IS NOT NULL");

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("AssignmentEF03.Entites.Instructor", b =>
                {
                    b.HasOne("AssignmentEF03.Entites.Department", "Dep")
                        .WithOne("Instructor")
                        .HasForeignKey("AssignmentEF03.Entites.Instructor", "Dept_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AssignmentEF03.Entites.Department", "Departments")
                        .WithMany("Instructors")
                        .HasForeignKey("Ins_ID");

                    b.Navigation("Dep");

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("AssignmentEF03.Entites.Students", b =>
                {
                    b.HasOne("AssignmentEF03.Entites.Department", "Departments")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentsId");

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("AssignmentEF03.Entites.Topic", b =>
                {
                    b.HasOne("AssignmentEF03.Entites.Course", "Courses")
                        .WithOne("Top_ID")
                        .HasForeignKey("AssignmentEF03.Entites.Topic", "Top_ID");

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("AssignmentEF03.Entites.Course", b =>
                {
                    b.Navigation("Top_ID");
                });

            modelBuilder.Entity("AssignmentEF03.Entites.Department", b =>
                {
                    b.Navigation("Instructor");

                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
