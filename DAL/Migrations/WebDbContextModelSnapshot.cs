﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Proj.DAL.Context;

namespace DAL.Migrations
{
    [DbContext(typeof(WebDbContext))]
    partial class WebDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Proj.DAL.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Deadline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 3,
                            CreatedAt = "03.07.2021 20:53:49",
                            Deadline = "03.07.2021 0:00:00",
                            Description = "bestProj",
                            Name = "SergoGagoProj",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            CreatedAt = "02.06.2010 0:00:00",
                            Deadline = "03.07.2021 0:00:00",
                            Description = "bestGavrulo",
                            Name = "GavruloProj",
                            TeamId = 2
                        });
                });

            modelBuilder.Entity("WebAPI.Proj.DAL.Entities.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FinishedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PerformerId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "do",
                            FinishedAt = new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "SergoTask",
                            PerformerId = 1,
                            ProjectId = 1,
                            State = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "do",
                            FinishedAt = new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "GagoTask",
                            PerformerId = 2,
                            ProjectId = 2,
                            State = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "do",
                            FinishedAt = new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "GagoTask",
                            PerformerId = 2,
                            ProjectId = 2,
                            State = 1
                        });
                });

            modelBuilder.Entity("WebAPI.Proj.DAL.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "SergoAndGago"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(1999, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "GavruloTeam"
                        });
                });

            modelBuilder.Entity("WebAPI.Proj.DAL.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDay = new DateTime(2002, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "serhiy2002shev@gmail.com",
                            FirstName = "Sergo",
                            LastName = "Shevchuk",
                            RegisteredAt = new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            BirthDay = new DateTime(1980, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "GagoGagoich@gmail.com",
                            FirstName = "Gago",
                            LastName = "Gagoich",
                            RegisteredAt = new DateTime(2001, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamId = 1
                        },
                        new
                        {
                            Id = 3,
                            BirthDay = new DateTime(2012, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Vista@gmail.com",
                            FirstName = "Gavrulo",
                            LastName = "Vista",
                            RegisteredAt = new DateTime(2019, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamId = 2
                        });
                });

            modelBuilder.Entity("WebAPI.Proj.DAL.Entities.Task", b =>
                {
                    b.HasOne("WebAPI.Proj.DAL.Entities.Project", "Project")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("WebAPI.Proj.DAL.Entities.User", b =>
                {
                    b.HasOne("WebAPI.Proj.DAL.Entities.Team", "Team")
                        .WithMany("Users")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("WebAPI.Proj.DAL.Entities.Project", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("WebAPI.Proj.DAL.Entities.Team", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
