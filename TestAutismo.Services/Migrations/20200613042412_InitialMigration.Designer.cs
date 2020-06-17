﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestAutismo.Services;

namespace TestAutismo.Services.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20200613042412_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestAutismo.Models.CentroEducativo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClaveCentro")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("DireccionCentro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCentro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CentroEducativos");
                });

            modelBuilder.Entity("TestAutismo.Models.Cuenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoElectronico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cuentas");
                });

            modelBuilder.Entity("TestAutismo.Models.Ninio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidosNinio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CentroEducativoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CurpNinio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimientoN")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fotografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nacionalidad")
                        .HasColumnType("int");

                    b.Property<string>("NombreNinio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TutorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CentroEducativoId");

                    b.HasIndex("TutorId");

                    b.ToTable("Ninios");
                });

            modelBuilder.Entity("TestAutismo.Models.Plantilla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Plantillas");
                });

            modelBuilder.Entity("TestAutismo.Models.Pregunta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("PlantillaId")
                        .HasColumnType("int");

                    b.Property<string>("PreguntaRealizada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Tipo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PlantillaId");

                    b.ToTable("Preguntas");
                });

            modelBuilder.Entity("TestAutismo.Models.Respuesta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("NinioId")
                        .HasColumnType("int");

                    b.Property<int>("PreguntaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("ValorRespuesta")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("NinioId");

                    b.HasIndex("PreguntaId");

                    b.ToTable("Respuestas");
                });

            modelBuilder.Entity("TestAutismo.Models.Tutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidosTutor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("CuentaId")
                        .HasColumnType("int");

                    b.Property<string>("CurpTutor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DireccionT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimientoT")
                        .HasColumnType("datetime2");

                    b.Property<int>("NacionalidadT")
                        .HasColumnType("int");

                    b.Property<string>("NombreTutor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CuentaId");

                    b.ToTable("Tutores");
                });

            modelBuilder.Entity("TestAutismo.Models.Ninio", b =>
                {
                    b.HasOne("TestAutismo.Models.CentroEducativo", "CentroEducativo")
                        .WithMany()
                        .HasForeignKey("CentroEducativoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestAutismo.Models.Tutor", "Tutor")
                        .WithMany("Ninio")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestAutismo.Models.Pregunta", b =>
                {
                    b.HasOne("TestAutismo.Models.Plantilla", "Plantilla")
                        .WithMany()
                        .HasForeignKey("PlantillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestAutismo.Models.Respuesta", b =>
                {
                    b.HasOne("TestAutismo.Models.Ninio", "Ninio")
                        .WithMany()
                        .HasForeignKey("NinioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestAutismo.Models.Pregunta", "Pregunta")
                        .WithMany()
                        .HasForeignKey("PreguntaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestAutismo.Models.Tutor", b =>
                {
                    b.HasOne("TestAutismo.Models.Cuenta", "Cuenta")
                        .WithMany()
                        .HasForeignKey("CuentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
