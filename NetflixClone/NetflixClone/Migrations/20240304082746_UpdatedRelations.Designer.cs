﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetflixClone.Data;

#nullable disable

namespace NetflixClone.Migrations
{
    [DbContext(typeof(NetflixCloneDbContext))]
    [Migration("20240304082746_UpdatedRelations")]
    partial class UpdatedRelations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NetflixClone.Models.Episodio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Numero_Episodio")
                        .HasColumnType("int");

                    b.Property<string>("Sinossi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StagioneId")
                        .HasColumnType("int");

                    b.Property<string>("Titolo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Episodi");
                });

            modelBuilder.Entity("NetflixClone.Models.Profilo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("UtenteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UtenteId");

                    b.ToTable("Profili");
                });

            modelBuilder.Entity("NetflixClone.Models.Stagione", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly?>("FineVisibilita")
                        .HasColumnType("date");

                    b.Property<DateOnly>("InizioVisibilita")
                        .HasColumnType("date");

                    b.Property<int>("NumeroStagione")
                        .HasColumnType("int");

                    b.Property<int>("SerieTvId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SerieTvId");

                    b.ToTable("Stagioni");
                });

            modelBuilder.Entity("NetflixClone.Models.Utente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data_Subscription")
                        .HasColumnType("datetime2");

                    b.Property<string>("Iban")
                        .HasMaxLength(17)
                        .HasColumnType("nvarchar(17)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Utenti");
                });

            modelBuilder.Entity("NetflixClone.Models.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sinossi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Voto")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Videos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Video");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("ProfiloVideo", b =>
                {
                    b.Property<int>("VideoVistiId")
                        .HasColumnType("int");

                    b.Property<int>("VisualizzatoriId")
                        .HasColumnType("int");

                    b.HasKey("VideoVistiId", "VisualizzatoriId");

                    b.HasIndex("VisualizzatoriId");

                    b.ToTable("ProfiloVideo");
                });

            modelBuilder.Entity("NetflixClone.Models.Film", b =>
                {
                    b.HasBaseType("NetflixClone.Models.Video");

                    b.Property<DateOnly?>("DataFine")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DataInizio")
                        .HasColumnType("date");

                    b.Property<int>("DurataInMin")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Film");
                });

            modelBuilder.Entity("NetflixClone.Models.SerieTv", b =>
                {
                    b.HasBaseType("NetflixClone.Models.Video");

                    b.Property<bool>("Completata")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("SerieTv");
                });

            modelBuilder.Entity("NetflixClone.Models.Profilo", b =>
                {
                    b.HasOne("NetflixClone.Models.Utente", "Utente")
                        .WithMany("Profili")
                        .HasForeignKey("UtenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utente");
                });

            modelBuilder.Entity("NetflixClone.Models.Stagione", b =>
                {
                    b.HasOne("NetflixClone.Models.SerieTv", null)
                        .WithMany("Stagioni")
                        .HasForeignKey("SerieTvId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProfiloVideo", b =>
                {
                    b.HasOne("NetflixClone.Models.Video", null)
                        .WithMany()
                        .HasForeignKey("VideoVistiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetflixClone.Models.Profilo", null)
                        .WithMany()
                        .HasForeignKey("VisualizzatoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NetflixClone.Models.Utente", b =>
                {
                    b.Navigation("Profili");
                });

            modelBuilder.Entity("NetflixClone.Models.SerieTv", b =>
                {
                    b.Navigation("Stagioni");
                });
#pragma warning restore 612, 618
        }
    }
}
