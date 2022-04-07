﻿// <auto-generated />
using System;
using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220407123613_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DataAccessLayer.Model.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Dept_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Departments");
                });

            modelBuilder.Entity("DataAccessLayer.Model.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Dept_Id")
                        .HasColumnType("int");

                    b.Property<string>("Employee_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employee_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employee_Salary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Employee_Status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Dept_Id");

                    b.ToTable("Tbl_Employees");
                });

            modelBuilder.Entity("DataAccessLayer.Model.Employee", b =>
                {
                    b.HasOne("DataAccessLayer.Model.Department", "Department")
                        .WithMany()
                        .HasForeignKey("Dept_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}