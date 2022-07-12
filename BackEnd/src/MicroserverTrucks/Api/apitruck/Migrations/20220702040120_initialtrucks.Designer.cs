﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apitruck.Data;

#nullable disable

namespace apitruck.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220702040120_initialtrucks")]
    partial class initialtrucks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("apitruck.Models.Encargado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Encargados");
                });

            modelBuilder.Entity("apitruck.Models.Transport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Plazas")
                        .HasColumnType("int");

                    b.Property<int>("RoutesId")
                        .HasColumnType("int");

                    b.Property<string>("Serie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("TypeTransportId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeTransportId");

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("apitruck.Models.TransportEncargado", b =>
                {
                    b.Property<int>("EncargadoId")
                        .HasColumnType("int");

                    b.Property<int>("TruckId")
                        .HasColumnType("int");

                    b.HasKey("EncargadoId", "TruckId");

                    b.HasIndex("TruckId");

                    b.ToTable("CamionEncargados");
                });

            modelBuilder.Entity("apitruck.Models.TypeTransport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("nametype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("apitruck.Models.Transport", b =>
                {
                    b.HasOne("apitruck.Models.TypeTransport", "typeTransport")
                        .WithMany("transports")
                        .HasForeignKey("TypeTransportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("typeTransport");
                });

            modelBuilder.Entity("apitruck.Models.TransportEncargado", b =>
                {
                    b.HasOne("apitruck.Models.Encargado", "encargado")
                        .WithMany("camionEncargados")
                        .HasForeignKey("EncargadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("apitruck.Models.Transport", "truck")
                        .WithMany("camionEncargados")
                        .HasForeignKey("TruckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("encargado");

                    b.Navigation("truck");
                });

            modelBuilder.Entity("apitruck.Models.Encargado", b =>
                {
                    b.Navigation("camionEncargados");
                });

            modelBuilder.Entity("apitruck.Models.Transport", b =>
                {
                    b.Navigation("camionEncargados");
                });

            modelBuilder.Entity("apitruck.Models.TypeTransport", b =>
                {
                    b.Navigation("transports");
                });
#pragma warning restore 612, 618
        }
    }
}
