﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SouthStudioBlog.Models;

namespace SouthStudioBlog.Migrations
{
    [DbContext(typeof(SSBContext))]
    [Migration("20200216094528_AddingMailToUserEntity")]
    partial class AddingMailToUserEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SouthStudioBlog.Models.Job", b =>
                {
                    b.Property<int>("IdJob")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("JobCompany")
                        .HasColumnType("text");

                    b.Property<string>("JobDescription")
                        .HasColumnType("text");

                    b.Property<DateTime>("JobEndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("JobPosition")
                        .HasColumnType("text");

                    b.Property<DateTime>("JobStartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("LastModificationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("LeavingDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UserIdUser")
                        .HasColumnType("integer");

                    b.HasKey("IdJob");

                    b.HasIndex("UserIdUser");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            IdJob = 1,
                            JobCompany = "Prodigia Consultores",
                            JobDescription = "Desarrollador de aplicaciones móviles en Android nativo.",
                            JobEndDate = new DateTime(2017, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JobPosition = "Desarrollador Android",
                            JobStartDate = new DateTime(2017, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserIdUser = 1
                        },
                        new
                        {
                            IdJob = 2,
                            JobCompany = "iUrban.es",
                            JobDescription = "Desarrollador de aplicaciones móviles en Android nativo.",
                            JobEndDate = new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JobPosition = "Desarrollador Android",
                            JobStartDate = new DateTime(2017, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserIdUser = 1
                        },
                        new
                        {
                            IdJob = 3,
                            JobCompany = "TYM Soluciones",
                            JobDescription = "Desarrollador de aplicaciones web en .Net Framework.",
                            JobEndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JobPosition = "Desarrollador .Net",
                            JobStartDate = new DateTime(2019, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserIdUser = 1
                        });
                });

            modelBuilder.Entity("SouthStudioBlog.Models.Post", b =>
                {
                    b.Property<int>("IdPost")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("LastModificationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("LeavingDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PostContent")
                        .HasColumnType("text");

                    b.Property<DateTime>("PostCreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<List<string>>("PostImages")
                        .HasColumnType("text[]");

                    b.Property<string>("PostTitle")
                        .HasColumnType("text");

                    b.Property<int>("UserIdUser")
                        .HasColumnType("integer");

                    b.HasKey("IdPost");

                    b.HasIndex("UserIdUser");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("SouthStudioBlog.Models.Study", b =>
                {
                    b.Property<int>("IdStudy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("LastModificationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("LeavingDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("StudyCenter")
                        .HasColumnType("text");

                    b.Property<string>("StudyDescription")
                        .HasColumnType("text");

                    b.Property<DateTime>("StudyEndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("StudyStartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("StudyTitle")
                        .HasColumnType("text");

                    b.Property<int>("UserIdUser")
                        .HasColumnType("integer");

                    b.HasKey("IdStudy");

                    b.HasIndex("UserIdUser");

                    b.ToTable("Studies");

                    b.HasData(
                        new
                        {
                            IdStudy = 1,
                            StudyCenter = "I.E.S. Belén",
                            StudyDescription = "Ciclo formativo de grado medio en administración de sistemas microinformaáticos y redes.",
                            StudyEndDate = new DateTime(2014, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudyStartDate = new DateTime(2011, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudyTitle = "Técnico en Administración de Sistemas Microinformáticos y Redes",
                            UserIdUser = 1
                        },
                        new
                        {
                            IdStudy = 2,
                            StudyCenter = "Cenec Málaga",
                            StudyDescription = "Ciclo formativo de grado superior en desarrollo de aplicaciones multiplataforma.",
                            StudyEndDate = new DateTime(2017, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudyStartDate = new DateTime(2015, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StudyTitle = "Técnico en Desarrollo de Aplicaciones Multiplataforma",
                            UserIdUser = 1
                        });
                });

            modelBuilder.Entity("SouthStudioBlog.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("LastModificationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("LeavingDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserAka")
                        .HasColumnType("text");

                    b.Property<DateTime>("UserBirthday")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserDescription")
                        .HasColumnType("text");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<string>("UserPassword")
                        .HasColumnType("text");

                    b.Property<string>("UserSurname")
                        .HasColumnType("text");

                    b.HasKey("IdUser");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            IdUser = 1,
                            UserAka = "JNoma",
                            UserBirthday = new DateTime(1994, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserDescription = "Pruebecita que te crió!",
                            UserName = "Jose",
                            UserSurname = "Álvarez Vivar"
                        });
                });

            modelBuilder.Entity("SouthStudioBlog.Models.Job", b =>
                {
                    b.HasOne("SouthStudioBlog.Models.User", null)
                        .WithMany("UserJobList")
                        .HasForeignKey("UserIdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SouthStudioBlog.Models.Post", b =>
                {
                    b.HasOne("SouthStudioBlog.Models.User", null)
                        .WithMany("UserPostList")
                        .HasForeignKey("UserIdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SouthStudioBlog.Models.Study", b =>
                {
                    b.HasOne("SouthStudioBlog.Models.User", null)
                        .WithMany("UserStudyList")
                        .HasForeignKey("UserIdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
