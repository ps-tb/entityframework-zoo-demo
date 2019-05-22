﻿// <auto-generated />
using EFDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EFDemo.Migrations
{
    [DbContext(typeof(ZooContext))]
    [Migration("20190522164534_AddOrderToAnimal")]
    partial class AddOrderToAnimal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("EFDemo.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Family");

                    b.Property<string>("Genus");

                    b.Property<string>("Name");

                    b.Property<string>("Order");

                    b.Property<string>("Species");

                    b.Property<int>("ZooId");

                    b.HasKey("AnimalId");

                    b.HasIndex("ZooId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("EFDemo.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("AnnualSalary");

                    b.Property<string>("Name");

                    b.Property<int>("ZooId");

                    b.HasKey("EmployeeId");

                    b.HasIndex("ZooId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EFDemo.Models.Zoo", b =>
                {
                    b.Property<int>("ZooId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<int>("AnnualBudge");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("YearFounded");

                    b.HasKey("ZooId");

                    b.ToTable("Zoos");
                });

            modelBuilder.Entity("EFDemo.Models.Animal", b =>
                {
                    b.HasOne("EFDemo.Models.Zoo", "Zoo")
                        .WithMany("Animals")
                        .HasForeignKey("ZooId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFDemo.Models.Employee", b =>
                {
                    b.HasOne("EFDemo.Models.Zoo", "Zoo")
                        .WithMany("Employees")
                        .HasForeignKey("ZooId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
