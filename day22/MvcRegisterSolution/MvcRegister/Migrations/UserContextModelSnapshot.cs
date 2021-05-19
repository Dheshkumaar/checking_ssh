﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcRegister.Models;

namespace MvcRegister.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcRegister.Models.EmployeeModel", b =>
                {
                    b.Property<int>("Emp_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Emp_Id");

                    b.HasIndex("Username");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("MvcRegister.Models.SalaryModel", b =>
                {
                    b.Property<int>("Salary_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Emp_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<double>("salary")
                        .HasColumnType("float");

                    b.HasKey("Salary_ID");

                    b.HasIndex("Emp_Id");

                    b.ToTable("Salary");
                });

            modelBuilder.Entity("MvcRegister.Models.UserModel", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Username = "qwerty",
                            password = "1234"
                        });
                });

            modelBuilder.Entity("MvcRegister.Models.EmployeeModel", b =>
                {
                    b.HasOne("MvcRegister.Models.UserModel", "UserModel")
                        .WithMany()
                        .HasForeignKey("Username");

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("MvcRegister.Models.SalaryModel", b =>
                {
                    b.HasOne("MvcRegister.Models.EmployeeModel", "employeeModel")
                        .WithMany()
                        .HasForeignKey("Emp_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employeeModel");
                });
#pragma warning restore 612, 618
        }
    }
}
