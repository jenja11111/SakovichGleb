﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SakovichGleb.Data;

namespace SakovichGleb.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221211104755_RaspisanieSmena")]
    partial class RaspisanieSmena
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SakovichGleb.Data.Models.Month", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdSemestr")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SemestrId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SemestrId");

                    b.ToTable("Months");
                });

            modelBuilder.Entity("SakovichGleb.Data.Models.NHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AllTime")
                        .HasColumnType("real");

                    b.Property<int>("ConsaltingDiplomaDesign")
                        .HasColumnType("int");

                    b.Property<int>("Consaltings")
                        .HasColumnType("int");

                    b.Property<float>("Exams")
                        .HasColumnType("real");

                    b.Property<float>("GEK")
                        .HasColumnType("real");

                    b.Property<int>("GuidanceDiplomaDesign")
                        .HasColumnType("int");

                    b.Property<int>("GuidancePost")
                        .HasColumnType("int");

                    b.Property<int>("IdMonth")
                        .HasColumnType("int");

                    b.Property<int>("KursWork")
                        .HasColumnType("int");

                    b.Property<int>("Labs")
                        .HasColumnType("int");

                    b.Property<int>("Lectures")
                        .HasColumnType("int");

                    b.Property<int>("Mag")
                        .HasColumnType("int");

                    b.Property<int?>("MonthId")
                        .HasColumnType("int");

                    b.Property<string>("Noil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Offsets")
                        .HasColumnType("int");

                    b.Property<int>("PracticesLessons")
                        .HasColumnType("int");

                    b.Property<int>("Practics")
                        .HasColumnType("int");

                    b.Property<int>("RGR")
                        .HasColumnType("int");

                    b.Property<int>("ReviewDiplomaDesign")
                        .HasColumnType("int");

                    b.Property<int>("TestWork")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MonthId");

                    b.ToTable("NHourses");
                });

            modelBuilder.Entity("SakovichGleb.Data.Models.Raspisanie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Smena")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Raspisanies");
                });

            modelBuilder.Entity("SakovichGleb.Data.Models.Semestr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<byte>("NSemestr")
                        .HasColumnType("tinyint");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Semestrs");
                });

            modelBuilder.Entity("SakovichGleb.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SakovichGleb.Data.Models.Month", b =>
                {
                    b.HasOne("SakovichGleb.Data.Models.Semestr", null)
                        .WithMany("Months")
                        .HasForeignKey("SemestrId");
                });

            modelBuilder.Entity("SakovichGleb.Data.Models.NHours", b =>
                {
                    b.HasOne("SakovichGleb.Data.Models.Month", null)
                        .WithMany("NHourses")
                        .HasForeignKey("MonthId");
                });

            modelBuilder.Entity("SakovichGleb.Data.Models.Raspisanie", b =>
                {
                    b.HasOne("SakovichGleb.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SakovichGleb.Data.Models.Semestr", b =>
                {
                    b.HasOne("SakovichGleb.Data.Models.User", null)
                        .WithMany("Semestrs")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("SakovichGleb.Data.Models.Month", b =>
                {
                    b.Navigation("NHourses");
                });

            modelBuilder.Entity("SakovichGleb.Data.Models.Semestr", b =>
                {
                    b.Navigation("Months");
                });

            modelBuilder.Entity("SakovichGleb.Data.Models.User", b =>
                {
                    b.Navigation("Semestrs");
                });
#pragma warning restore 612, 618
        }
    }
}
